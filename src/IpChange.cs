using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;

namespace IPChange
{
    public partial class IpChange : Form
    {
        private const string INIFILENAME = "IP_Change.ini";
        private const string KEYNAME_IP = "Ip";
        private const string KEYNAME_DNS1 = "Dns1";
        private const string KEYNAME_DNS2 = "Dns2";
        private const string KEYNAME_SUBNETMASK = "SubnetMask";
        private const string KEYNAME_GATEWAY = "Gateway";
        private const string DHCP = "DHCP";

        private System.Diagnostics.ProcessStartInfo m_processInfo;
        private System.Diagnostics.Process m_process;
        private IniFile ipSettings;
        private IpConfigViewForm m_view;
        private string m_selectedItemName;
        private string m_currentPath;

        private struct networkInterfaceInfo
        {
            public string ipAddress;
            public string interfaceDescription;
            public string subnetMask;
            public List<string> gatewateAddresses;
            public bool dhcpEnable;
            public bool dynamicDnsEnabled;
            public List<string> dhcpServers;
            public List<string> dnsServers;
        }

        private Dictionary<string, networkInterfaceInfo> networkInfo;

        public IpChange()
        {
            InitializeComponent();

            ipSettings = new IniFile();
            
            m_view = new IpConfigViewForm();
            m_view.RefreshIpconfig += new EventHandler(view_Refresh);

            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = System.IO.Path.GetDirectoryName(path);
            m_currentPath = path + "\\" + INIFILENAME;

            initCmdProcess();
            DisplayNetworkInfo();
            loadIniConfig();
        }

        private void loadIniConfig()
        {
            if (!File.Exists(m_currentPath))
            {
                return;
            }

            ipSettings.Load(m_currentPath);

            listViewConfig.BeginUpdate();
            foreach (IniFile.IniSection section in ipSettings.Sections)
            {
                ListViewItem item = new ListViewItem(section.Name);
                
                Dictionary<string, string> keyValues = new Dictionary<string, string>();
                foreach (IniFile.IniSection.IniKey key in section.Keys)
                {
                    if (key.Value != string.Empty)
                    {
                        keyValues.Add(key.Name, key.Value);                
                    }
                }

                item.SubItems.Add(keyValues[KEYNAME_IP]);
                item.SubItems.Add(keyValues[KEYNAME_DNS1]);
                listViewConfig.Items.Add(item);
            }
            listViewConfig.EndUpdate();
        }

        private void initCmdProcess()
        {
            m_processInfo = new System.Diagnostics.ProcessStartInfo();
            m_process = new System.Diagnostics.Process();

            m_processInfo.FileName = @"cmd";
            m_processInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            m_processInfo.CreateNoWindow = true;
            m_processInfo.UseShellExecute = false;
            // cmd 데이터 받기
            m_processInfo.RedirectStandardOutput = true;
            // cmd 데이터 보내기
            m_processInfo.RedirectStandardInput = true;
            // cmd 오류내용 받기
            m_processInfo.RedirectStandardError = true;
            m_process.EnableRaisingEvents = false;
            m_process.StartInfo = m_processInfo;
        }

        private void DisplayNetworkInfo()
        {
            networkInfo = new Dictionary<string,networkInterfaceInfo>();
            
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                networkInterfaceInfo info = new networkInterfaceInfo();
                info.gatewateAddresses = new List<string>();
                info.dhcpServers = new List<string>();
                info.dnsServers = new List<string>();
                info.dhcpEnable = false;

                IPInterfaceProperties adapterProperites = adapter.GetIPProperties();
                GatewayIPAddressInformationCollection gatewayAddresses = adapterProperites.GatewayAddresses;
                IPAddressCollection dhcpServers = adapterProperites.DhcpServerAddresses;
                IPAddressCollection dnsServers = adapterProperites.DnsAddresses;

                info.interfaceDescription = adapter.Description;

                info = getIpAddress(info, adapterProperites);
                info = getGatewayAddress(info, gatewayAddresses);
                info = getDhcpEnabled(adapter, info, adapterProperites);
                info = getDhcpServerAddress(info, dhcpServers);
                info = getDnsServerAddress(info, dnsServers);

                networkInfo.Add(adapter.Name, info);
            }

            int seletedInaterCardIndex = comboNetwokInterface.SelectedIndex;

            comboNetwokInterface.DataSource = new BindingSource(networkInfo, null);
            comboNetwokInterface.DisplayMember = "Key";
            comboNetwokInterface.ValueMember = "Value";

            comboNetwokInterface.SelectedIndex = seletedInaterCardIndex < 0 ? 0 : seletedInaterCardIndex;
        }

        private networkInterfaceInfo getDnsServerAddress(networkInterfaceInfo info, IPAddressCollection dnsServers)
        {
            if (dnsServers.Count > 0)
            {
                foreach (IPAddress dns in dnsServers)
                {
                    info.dnsServers.Add(dns.ToString());
                }
            }
            return info;
        }

        private networkInterfaceInfo getDhcpServerAddress(networkInterfaceInfo info, IPAddressCollection dhcpServers)
        {
            if (dhcpServers.Count > 0)
            {
                foreach (IPAddress dhcp in dhcpServers)
                {
                    info.dhcpServers.Add(dhcp.ToString());
                }
            }
            return info;
        }

        private networkInterfaceInfo getDhcpEnabled(NetworkInterface adapter, networkInterfaceInfo info, IPInterfaceProperties adapterProperites)
        {
            info.dynamicDnsEnabled = adapterProperites.IsDynamicDnsEnabled;
            if (adapter.Supports(NetworkInterfaceComponent.IPv4) == true)
            {
                IPv4InterfaceProperties ipv4Properties = adapterProperites.GetIPv4Properties();

                if (ipv4Properties != null)
                {
                    info.dhcpEnable = ipv4Properties.IsDhcpEnabled;
                    string enable = ipv4Properties.IsDhcpEnabled ? "Enable" : "Disable";
                }
            }
            return info;
        }

        private networkInterfaceInfo getGatewayAddress(networkInterfaceInfo info, GatewayIPAddressInformationCollection gatewayAddresses)
        {
            if (gatewayAddresses.Count > 0)
            {
                foreach (GatewayIPAddressInformation address in gatewayAddresses)
                {
                    info.gatewateAddresses.Add(address.Address.ToString());
                }
            }
            return info;
        }

        private networkInterfaceInfo getIpAddress(networkInterfaceInfo info, IPInterfaceProperties adapterProperites)
        {
            foreach (UnicastIPAddressInformation ip in adapterProperites.UnicastAddresses)
            {
                if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    info.ipAddress = ip.Address.ToString();
                    if (ip.IPv4Mask != null)
                    {
                        info.subnetMask = ip.IPv4Mask.ToString();
                    }
                }
            }
            return info;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            m_process.Start();

            m_process.StandardInput.Write("netsh interface ip set address name = \"무선 네트워크 연결\" static 222.112.200.181 255.255.255.0 222.112.200.1 1" + Environment.NewLine);
            m_process.StandardInput.Write("netsh interface ip add dns name = \"무선 네트워크 연결\" 168.126.63.1" + Environment.NewLine);
            m_process.StandardInput.Close();

            // 결과 값을 리턴
            string resultValue = m_process.StandardOutput.ReadToEnd();

            m_process.WaitForExit();
            m_process.Close();

            DisplayNetworkInfo();
        }

        private void buttonDHCP_Click(object sender, EventArgs e)
        {
            m_process.Start();

            m_process.StandardInput.Write("netsh interface ip set address name = \"무선 네트워크 연결\" source=dhcp" + Environment.NewLine);
            m_process.StandardInput.Write("netsh interface ip set dns name = \"무선 네트워크 연결\" source=dhcp" + Environment.NewLine);
            m_process.StandardInput.Close();

            // 결과 값을 리턴
            string resultValue = m_process.StandardOutput.ReadToEnd();

            m_process.WaitForExit();
            m_process.Close();

            DisplayNetworkInfo();
        }

        private void comboNetwokInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            networkInterfaceInfo value = ((KeyValuePair<string, networkInterfaceInfo>)comboNetwokInterface.SelectedItem).Value;

            textBoxIpAddress.Text = value.ipAddress;
            textBoxSubnetMask.Text = value.subnetMask;
            textBoxGatway.Text = "";
            textBoxDns.Text = "";
            textBoxSecondDns.Text = "";

            textBoxInterfaceName.Text = value.interfaceDescription;
            
            if (value.gatewateAddresses.Count > 0)
            {
                textBoxGatway.Text = value.gatewateAddresses[0];
            }

            if (value.dnsServers.Count > 0)
            {
                int count = 0;
                foreach (string dns in value.dnsServers)
                {
                    switch (count)
                    {
                        case 0:
                            {
                                textBoxDns.Text = value.dnsServers[0];
                                break;
                            }
                        case 1:
                            {
                                textBoxSecondDns.Text = value.dnsServers[1];
                                break;
                            }
                    }

                    count++;
                }
            }

            checkBoxDhcpEnabled.Checked = value.dhcpEnable;
            checkBoxDynamicDnsEnabled.Checked = value.dhcpEnable;
        }

        private void checkBoxSetIp_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;

            panelIp.Enabled = !box.Checked;
            checkBoxSetDns.Enabled = box.Checked;
        }

        private void checkBoxSetDns_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;

            panelDns.Enabled = !box.Checked;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            clearControl();
        }

        private void clearControl()
        {
            textBoxSaveName.Text = "";
            checkBoxSetIp.Checked = false;
            textBoxSetIp.Text = "";
            textBoxSetSubnetMask.Text = "";
            textBoxGateway.Text = "";
            checkBoxSetDns.Checked = false;
            textBoxSetDns1.Text = "";
            textBoxSetDns2.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxSaveName.Text == string.Empty)
            {
                MessageBox.Show("설정 이름을 입력해 주세요.!");
                return;
            }

            string ipAddress = checkBoxSetIp.Checked ? DHCP : textBoxSetIp.Text;
            ipSettings.SetKeyValue(textBoxSaveName.Text, KEYNAME_IP, ipAddress);            
            ipSettings.SetKeyValue(textBoxSaveName.Text, KEYNAME_SUBNETMASK, textBoxSetSubnetMask.Text);
            ipSettings.SetKeyValue(textBoxSaveName.Text, KEYNAME_GATEWAY, textBoxGateway.Text);

            string dns1Address = checkBoxSetDns.Checked ? DHCP : textBoxSetDns1.Text;
            string dns2Address = checkBoxSetDns.Checked ? DHCP : textBoxSetDns2.Text;
            ipSettings.SetKeyValue(textBoxSaveName.Text, KEYNAME_DNS1, dns1Address);
            ipSettings.SetKeyValue(textBoxSaveName.Text, KEYNAME_DNS2, dns2Address);
            
            ipSettings.Save(m_currentPath);

            listViewConfig.Items.Clear();
            loadIniConfig();
        }

        private void buttonIpconfig_Click(object sender, EventArgs e)
        {
            string resultValue = sendCommadIpconfig();
            m_view.setText(resultValue);

            m_view.Show();
        }

        private string sendCommadIpconfig()
        {
            m_process.Start();
            m_process.StandardInput.Write("ipconfig /all" + Environment.NewLine);
            m_process.StandardInput.Close();

            // 결과 값을 리턴
            string resultValue = m_process.StandardOutput.ReadToEnd();

            m_process.WaitForExit();
            m_process.Close();
            
            return resultValue;
        }

        void view_Refresh(object sender, EventArgs e)
        {
            string resultValue = sendCommadIpconfig();
            m_view.setText(resultValue);
        }

        private void listViewConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewConfig.SelectedIndices.Count > 0)
            {
                ListViewItem item = listViewConfig.SelectedItems[0];
                m_selectedItemName = item.SubItems[0].Text;

                textBoxSaveName.Text = m_selectedItemName;
                string ipAddress = ipSettings.GetKeyValue(m_selectedItemName, KEYNAME_IP);
                if (ipAddress == DHCP)
                {
                    checkBoxSetIp.Checked = true;
                    textBoxSetIp.Text = "";
                }
                else
                {
                    checkBoxSetIp.Checked = false;
                    textBoxSetIp.Text = ipAddress;
                }
                
                textBoxSetSubnetMask.Text = ipSettings.GetKeyValue(m_selectedItemName, KEYNAME_SUBNETMASK);
                textBoxGateway.Text = ipSettings.GetKeyValue(m_selectedItemName, KEYNAME_GATEWAY);

                string dnsAddress = ipSettings.GetKeyValue(m_selectedItemName, KEYNAME_DNS1);
                if (dnsAddress == DHCP)
                {
                    textBoxSetDns1.Text = "";
                    textBoxSetDns2.Text = "";
                    checkBoxSetDns.Checked = true;
                }
                else
                {
                    textBoxSetDns1.Text = dnsAddress;
                    textBoxSetDns2.Text = ipSettings.GetKeyValue(m_selectedItemName, KEYNAME_DNS2);;
                    checkBoxSetDns.Checked = false;
                }
            }
        }

        private void listViewConfig_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                MenuItem m1 = new MenuItem("설정적용");
                m1.Click += OnMenuItemClick;
                menu.MenuItems.Add(m1);
                MenuItem m2 = new MenuItem("삭제");
                m2.Click += OnMenuItemClick;
                menu.MenuItems.Add(m2);
                MenuItem m3 = new MenuItem("이름변경");
                m3.Click += OnMenuItemClick;
                menu.MenuItems.Add(m3);

                if (listViewConfig.FocusedItem.Bounds.Contains(new Point(e.X, e.Y)) == true)
                {
                    int index = listViewConfig.FocusedItem.Index;
                    menu.Show(listViewConfig, new Point(e.X, e.Y));
                }
            }
        }

        private void OnMenuItemClick(object sender, EventArgs e)
        {
            switch (((MenuItem)sender).Text)
            {
                case "설정적용":
                    {
                        settingIpConfig();
                        break;
                    }
                case "삭제":
                    {
                        deleteItem();
                        break;
                    }
                case "이름변경":
                    {
                        renameItem();
                        break;
                    }
            }
        }

        private void renameItem()
        {
            InputNewNameForm form = new InputNewNameForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string newName = form.newName;
                ipSettings.RenameSection(m_selectedItemName, newName);
                ipSettings.Save(m_currentPath);

                listViewConfig.Items.Clear();
                loadIniConfig();
            }
            
        }

        private void deleteItem()
        {
            if (MessageBox.Show("[" + m_selectedItemName + "] 을 삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                ipSettings.RemoveSection(m_selectedItemName);
                ipSettings.Save(m_currentPath);

                listViewConfig.Items.Clear();
                loadIniConfig();

                clearControl();
            }
        }

        private void settingIpConfig()
        {
            string selectedInterfaceCard = comboNetwokInterface.Text;
            string selectedSettingName = textBoxSaveName.Text;
            
            if (selectedSettingName == string.Empty)
            {
                MessageBox.Show("설정을 선택해 주세요.");
                return;
            }

            if (MessageBox.Show("[" + selectedInterfaceCard + "] 의 설정을 [" + selectedSettingName + "]로 변경 하시겠습니까?", "변경 확인", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                m_process.Start();

                // Enable DHCP IP
                if (checkBoxSetIp.Checked)
                {
                    m_process.StandardInput.Write("netsh interface ip set address name = \"" + selectedInterfaceCard + "\" source=dhcp" + Environment.NewLine);
                }
                else        // static ip
                {
                    StringBuilder command = new StringBuilder();
                    command.Append("netsh interface ip set address name = \"");
                    command.Append(selectedInterfaceCard);
                    command.Append("\" static ");

                    if (textBoxSetIp.Text == string.Empty)
                    {
                        displayMessage("IP 값이 없습니다.");
                        return;
                    }
                    else
                    {
                        if (checkIpAddress(textBoxSetIp.Text))
                        {
                            command.Append(textBoxSetIp.Text + " ");
                        }
                        else
                        {
                            displayMessage("IP 값의 형식이 틀립니다.");
                            return;
                        }
                        
                    }

                    if (textBoxSetSubnetMask.Text == string.Empty)
                    {
                        displayMessage("서브넷 마스크 값이 없습니다.");
                        return;
                    }
                    else
                    {
                        if (checkIpAddress(textBoxSetIp.Text))
                        {
                            command.Append(textBoxSetSubnetMask.Text + " ");
                        }
                        else
                        {
                            displayMessage("서브넷 마스크 값의 형식이 틀립니다.");
                            return;
                        }
                    }

                    if (textBoxGateway.Text == string.Empty)
                    {
                        displayMessage("기본 게이트웨이 값이 없습니다.");
                        return;
                    }
                    else
                    {
                        if (checkIpAddress(textBoxSetIp.Text))
                        {
                            command.Append(textBoxGateway.Text + " ");
                        }
                        else
                        {
                            displayMessage("기본 게이트웨이 값의 형식이 틀립니다.");
                            return;
                        }
                    }

                    command.Append("1");
                    m_process.StandardInput.Write(command + Environment.NewLine);
                }

                // enable DHCP dns
                if (checkBoxSetDns.Checked)
                {
                    m_process.StandardInput.Write("netsh interface ip set dns name = \"" + selectedInterfaceCard + "\" source=dhcp" + Environment.NewLine);
                }
                else        // static dns
                {
                    // set dns1
                    if (textBoxSetDns1.Text == string.Empty)
                    {
                        displayMessage("DNS 서버 1 값이 없습니다.");
                        return;
                    }
                    else
                    {
                        if (checkIpAddress(textBoxSetIp.Text))
                        {
                            m_process.StandardInput.Write("netsh interface ip add dns name = \"" + selectedInterfaceCard + "\" " + textBoxSetDns1.Text + Environment.NewLine);
                        }
                        else
                        {
                            displayMessage("DNS 서버 1 값의 형식이 틀립니다.");
                            return;
                        }
                    }

                    // set dns2
                    if (textBoxSetDns2.Text != string.Empty)
                    {
                        if (checkIpAddress(textBoxSetIp.Text))
                        {
                            m_process.StandardInput.Write("netsh interface ip add dns name = \"" + selectedInterfaceCard + "\" " + textBoxSetDns2.Text + Environment.NewLine);
                        }
                        else
                        {
                            displayMessage("DNS 서버 2 값의 형식이 틀립니다.");
                            return;
                        }
                    }
                }

                processClose();

                DisplayNetworkInfo();

                MessageBox.Show("설정 완료.");
            }
        }

        private void buttonSetIp_Click(object sender, EventArgs e)
        {
            settingIpConfig();
        }

        private void processClose()
        {
            m_process.StandardInput.Close();

            // 결과 값을 리턴
            string resultValue = m_process.StandardOutput.ReadToEnd();

            m_process.WaitForExit();
            m_process.Close();
        }

        private bool checkIpAddress(string ipAddress)
        {
            string pattern = @"^(?:(:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            if (System.Text.RegularExpressions.Regex.IsMatch(ipAddress, pattern))
            {
                return true;
            }
            return false;
        }

        private void displayMessage(string message)
        {
            MessageBox.Show(message);
            processClose();
        }
    }
}
