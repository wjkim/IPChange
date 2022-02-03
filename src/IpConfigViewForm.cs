using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPChange
{
    public partial class IpConfigViewForm : Form
    {
        public event EventHandler RefreshIpconfig;
        public IpConfigViewForm()
        {
            InitializeComponent();
        }

        public void setText(string data)
        {
            textBoxIpconfig.Text = data;

            DateTime now = DateTime.Now;
            labelLastUpdate.Text = "Last Update : " + now.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (RefreshIpconfig != null)
            {
                RefreshIpconfig(this, e);
            }
        }
    }

    public class RefreshEventArg : EventArgs
    {
        public RefreshEventArg(){}
    }
}
