namespace IPChange
{
    partial class IpChange
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IpChange));
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonDHCP = new System.Windows.Forms.Button();
            this.comboNetwokInterface = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.textBoxSubnetMask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGatway = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSecondDns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxDhcpEnabled = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInterfaceName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxDynamicDnsEnabled = new System.Windows.Forms.CheckBox();
            this.listViewConfig = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dns = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSaveName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelDns = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSetDns2 = new System.Windows.Forms.TextBox();
            this.textBoxSetDns1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxSetDns = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panelIp = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxGateway = new System.Windows.Forms.TextBox();
            this.textBoxSetIp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSetSubnetMask = new System.Windows.Forms.TextBox();
            this.checkBoxSetIp = new System.Windows.Forms.CheckBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonIpconfig = new System.Windows.Forms.Button();
            this.buttonSetIp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelDns.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelIp.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(391, 397);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 0;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Visible = false;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonDHCP
            // 
            this.buttonDHCP.Location = new System.Drawing.Point(484, 397);
            this.buttonDHCP.Name = "buttonDHCP";
            this.buttonDHCP.Size = new System.Drawing.Size(75, 23);
            this.buttonDHCP.TabIndex = 1;
            this.buttonDHCP.Text = "DHCP Set";
            this.buttonDHCP.UseVisualStyleBackColor = true;
            this.buttonDHCP.Visible = false;
            this.buttonDHCP.Click += new System.EventHandler(this.buttonDHCP_Click);
            // 
            // comboNetwokInterface
            // 
            this.comboNetwokInterface.FormattingEnabled = true;
            this.comboNetwokInterface.Location = new System.Drawing.Point(104, 12);
            this.comboNetwokInterface.Name = "comboNetwokInterface";
            this.comboNetwokInterface.Size = new System.Drawing.Size(267, 20);
            this.comboNetwokInterface.TabIndex = 3;
            this.comboNetwokInterface.SelectedIndexChanged += new System.EventHandler(this.comboNetwokInterface_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP 주소 : ";
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Location = new System.Drawing.Point(118, 52);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.ReadOnly = true;
            this.textBoxIpAddress.Size = new System.Drawing.Size(214, 21);
            this.textBoxIpAddress.TabIndex = 5;
            // 
            // textBoxSubnetMask
            // 
            this.textBoxSubnetMask.Location = new System.Drawing.Point(118, 81);
            this.textBoxSubnetMask.Name = "textBoxSubnetMask";
            this.textBoxSubnetMask.ReadOnly = true;
            this.textBoxSubnetMask.Size = new System.Drawing.Size(214, 21);
            this.textBoxSubnetMask.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "서브넷 마스크 : ";
            // 
            // textBoxGatway
            // 
            this.textBoxGatway.Location = new System.Drawing.Point(118, 114);
            this.textBoxGatway.Name = "textBoxGatway";
            this.textBoxGatway.ReadOnly = true;
            this.textBoxGatway.Size = new System.Drawing.Size(214, 21);
            this.textBoxGatway.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "기본 게이트웨이 : ";
            // 
            // textBoxDns
            // 
            this.textBoxDns.Location = new System.Drawing.Point(118, 55);
            this.textBoxDns.Name = "textBoxDns";
            this.textBoxDns.ReadOnly = true;
            this.textBoxDns.Size = new System.Drawing.Size(214, 21);
            this.textBoxDns.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "DNS 서버 1 : ";
            // 
            // textBoxSecondDns
            // 
            this.textBoxSecondDns.Location = new System.Drawing.Point(118, 88);
            this.textBoxSecondDns.Name = "textBoxSecondDns";
            this.textBoxSecondDns.ReadOnly = true;
            this.textBoxSecondDns.Size = new System.Drawing.Size(214, 21);
            this.textBoxSecondDns.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "DNS 서버 2 : ";
            // 
            // checkBoxDhcpEnabled
            // 
            this.checkBoxDhcpEnabled.AutoSize = true;
            this.checkBoxDhcpEnabled.Enabled = false;
            this.checkBoxDhcpEnabled.Location = new System.Drawing.Point(7, 26);
            this.checkBoxDhcpEnabled.Name = "checkBoxDhcpEnabled";
            this.checkBoxDhcpEnabled.Size = new System.Drawing.Size(194, 16);
            this.checkBoxDhcpEnabled.TabIndex = 15;
            this.checkBoxDhcpEnabled.Text = " 자동으로 IP 주소 받기 (DHCP)";
            this.checkBoxDhcpEnabled.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "이더넷 어댑터 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "사용할 장치 : ";
            // 
            // textBoxInterfaceName
            // 
            this.textBoxInterfaceName.Location = new System.Drawing.Point(105, 39);
            this.textBoxInterfaceName.Name = "textBoxInterfaceName";
            this.textBoxInterfaceName.ReadOnly = true;
            this.textBoxInterfaceName.Size = new System.Drawing.Size(266, 21);
            this.textBoxInterfaceName.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDhcpEnabled);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIpAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSubnetMask);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxGatway);
            this.groupBox1.Location = new System.Drawing.Point(7, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 144);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxDynamicDnsEnabled);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxDns);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxSecondDns);
            this.groupBox2.Location = new System.Drawing.Point(7, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 121);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DNS";
            // 
            // checkBoxDynamicDnsEnabled
            // 
            this.checkBoxDynamicDnsEnabled.AutoSize = true;
            this.checkBoxDynamicDnsEnabled.Enabled = false;
            this.checkBoxDynamicDnsEnabled.Location = new System.Drawing.Point(9, 25);
            this.checkBoxDynamicDnsEnabled.Name = "checkBoxDynamicDnsEnabled";
            this.checkBoxDynamicDnsEnabled.Size = new System.Drawing.Size(236, 16);
            this.checkBoxDynamicDnsEnabled.TabIndex = 16;
            this.checkBoxDynamicDnsEnabled.Text = " 자동으로 DNS 서버 주소 받기 (DHCP)";
            this.checkBoxDynamicDnsEnabled.UseVisualStyleBackColor = true;
            // 
            // listViewConfig
            // 
            this.listViewConfig.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.ip,
            this.dns});
            this.listViewConfig.FullRowSelect = true;
            this.listViewConfig.Location = new System.Drawing.Point(7, 369);
            this.listViewConfig.MultiSelect = false;
            this.listViewConfig.Name = "listViewConfig";
            this.listViewConfig.Size = new System.Drawing.Size(364, 116);
            this.listViewConfig.TabIndex = 21;
            this.listViewConfig.UseCompatibleStateImageBehavior = false;
            this.listViewConfig.View = System.Windows.Forms.View.Details;
            this.listViewConfig.SelectedIndexChanged += new System.EventHandler(this.listViewConfig_SelectedIndexChanged);
            this.listViewConfig.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewConfig_MouseClick);
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 100;
            // 
            // ip
            // 
            this.ip.Text = "IP";
            this.ip.Width = 130;
            // 
            // dns
            // 
            this.dns.Text = "DNS";
            this.dns.Width = 130;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "설정 이름 : ";
            // 
            // textBoxSaveName
            // 
            this.textBoxSaveName.Location = new System.Drawing.Point(464, 12);
            this.textBoxSaveName.Name = "textBoxSaveName";
            this.textBoxSaveName.Size = new System.Drawing.Size(214, 21);
            this.textBoxSaveName.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelDns);
            this.groupBox3.Controls.Add(this.checkBoxSetDns);
            this.groupBox3.Location = new System.Drawing.Point(391, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 121);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DNS";
            // 
            // panelDns
            // 
            this.panelDns.Controls.Add(this.label9);
            this.panelDns.Controls.Add(this.textBoxSetDns2);
            this.panelDns.Controls.Add(this.textBoxSetDns1);
            this.panelDns.Controls.Add(this.label10);
            this.panelDns.Location = new System.Drawing.Point(9, 49);
            this.panelDns.Name = "panelDns";
            this.panelDns.Size = new System.Drawing.Size(331, 64);
            this.panelDns.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "DNS 서버 1 : ";
            // 
            // textBoxSetDns2
            // 
            this.textBoxSetDns2.Location = new System.Drawing.Point(109, 37);
            this.textBoxSetDns2.Name = "textBoxSetDns2";
            this.textBoxSetDns2.Size = new System.Drawing.Size(214, 21);
            this.textBoxSetDns2.TabIndex = 13;
            // 
            // textBoxSetDns1
            // 
            this.textBoxSetDns1.Location = new System.Drawing.Point(109, 4);
            this.textBoxSetDns1.Name = "textBoxSetDns1";
            this.textBoxSetDns1.Size = new System.Drawing.Size(214, 21);
            this.textBoxSetDns1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "DNS 서버 2 : ";
            // 
            // checkBoxSetDns
            // 
            this.checkBoxSetDns.AutoSize = true;
            this.checkBoxSetDns.Enabled = false;
            this.checkBoxSetDns.Location = new System.Drawing.Point(9, 25);
            this.checkBoxSetDns.Name = "checkBoxSetDns";
            this.checkBoxSetDns.Size = new System.Drawing.Size(236, 16);
            this.checkBoxSetDns.TabIndex = 16;
            this.checkBoxSetDns.Text = " 자동으로 DNS 서버 주소 받기 (DHCP)";
            this.checkBoxSetDns.UseVisualStyleBackColor = true;
            this.checkBoxSetDns.CheckedChanged += new System.EventHandler(this.checkBoxSetDns_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panelIp);
            this.groupBox4.Controls.Add(this.checkBoxSetIp);
            this.groupBox4.Location = new System.Drawing.Point(391, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 144);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IP";
            // 
            // panelIp
            // 
            this.panelIp.Controls.Add(this.label11);
            this.panelIp.Controls.Add(this.textBoxGateway);
            this.panelIp.Controls.Add(this.textBoxSetIp);
            this.panelIp.Controls.Add(this.label13);
            this.panelIp.Controls.Add(this.label12);
            this.panelIp.Controls.Add(this.textBoxSetSubnetMask);
            this.panelIp.Location = new System.Drawing.Point(7, 44);
            this.panelIp.Name = "panelIp";
            this.panelIp.Size = new System.Drawing.Size(330, 96);
            this.panelIp.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "IP 주소 : ";
            // 
            // textBoxGateway
            // 
            this.textBoxGateway.Location = new System.Drawing.Point(111, 71);
            this.textBoxGateway.Name = "textBoxGateway";
            this.textBoxGateway.Size = new System.Drawing.Size(214, 21);
            this.textBoxGateway.TabIndex = 9;
            // 
            // textBoxSetIp
            // 
            this.textBoxSetIp.Location = new System.Drawing.Point(111, 9);
            this.textBoxSetIp.Name = "textBoxSetIp";
            this.textBoxSetIp.Size = new System.Drawing.Size(214, 21);
            this.textBoxSetIp.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "기본 게이트웨이 : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "서브넷 마스크 : ";
            // 
            // textBoxSetSubnetMask
            // 
            this.textBoxSetSubnetMask.Location = new System.Drawing.Point(111, 38);
            this.textBoxSetSubnetMask.Name = "textBoxSetSubnetMask";
            this.textBoxSetSubnetMask.Size = new System.Drawing.Size(214, 21);
            this.textBoxSetSubnetMask.TabIndex = 7;
            // 
            // checkBoxSetIp
            // 
            this.checkBoxSetIp.AutoSize = true;
            this.checkBoxSetIp.Location = new System.Drawing.Point(7, 26);
            this.checkBoxSetIp.Name = "checkBoxSetIp";
            this.checkBoxSetIp.Size = new System.Drawing.Size(194, 16);
            this.checkBoxSetIp.TabIndex = 15;
            this.checkBoxSetIp.Text = " 자동으로 IP 주소 받기 (DHCP)";
            this.checkBoxSetIp.UseVisualStyleBackColor = true;
            this.checkBoxSetIp.CheckedChanged += new System.EventHandler(this.checkBoxSetIp_CheckedChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(391, 451);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(81, 34);
            this.buttonNew.TabIndex = 26;
            this.buttonNew.Text = "새로 만들기";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(478, 451);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(81, 34);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "저장하기";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonIpconfig
            // 
            this.buttonIpconfig.Location = new System.Drawing.Point(565, 451);
            this.buttonIpconfig.Name = "buttonIpconfig";
            this.buttonIpconfig.Size = new System.Drawing.Size(81, 34);
            this.buttonIpconfig.TabIndex = 28;
            this.buttonIpconfig.Text = "IPCONFIG";
            this.buttonIpconfig.UseVisualStyleBackColor = true;
            this.buttonIpconfig.Click += new System.EventHandler(this.buttonIpconfig_Click);
            // 
            // buttonSetIp
            // 
            this.buttonSetIp.Location = new System.Drawing.Point(652, 451);
            this.buttonSetIp.Name = "buttonSetIp";
            this.buttonSetIp.Size = new System.Drawing.Size(81, 34);
            this.buttonSetIp.TabIndex = 29;
            this.buttonSetIp.Text = "설정적용";
            this.buttonSetIp.UseVisualStyleBackColor = true;
            this.buttonSetIp.Click += new System.EventHandler(this.buttonSetIp_Click);
            // 
            // IpChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 493);
            this.Controls.Add(this.buttonSetIp);
            this.Controls.Add(this.buttonIpconfig);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBoxSaveName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listViewConfig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxInterfaceName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboNetwokInterface);
            this.Controls.Add(this.buttonDHCP);
            this.Controls.Add(this.buttonSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IpChange";
            this.Text = "IP Change";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelDns.ResumeLayout(false);
            this.panelDns.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelIp.ResumeLayout(false);
            this.panelIp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonDHCP;
        private System.Windows.Forms.ComboBox comboNetwokInterface;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.TextBox textBoxSubnetMask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGatway;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSecondDns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxDhcpEnabled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxInterfaceName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxDynamicDnsEnabled;
        private System.Windows.Forms.ListView listViewConfig;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader ip;
        private System.Windows.Forms.ColumnHeader dns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSaveName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxSetDns;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSetDns1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSetDns2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxSetIp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSetIp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSetSubnetMask;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxGateway;
        private System.Windows.Forms.Panel panelDns;
        private System.Windows.Forms.Panel panelIp;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonIpconfig;
        private System.Windows.Forms.Button buttonSetIp;
    }
}

