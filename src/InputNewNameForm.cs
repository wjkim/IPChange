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
    public partial class InputNewNameForm : Form
    {
        public InputNewNameForm()
        {
            InitializeComponent();
        }

        public string newName
        {
            get { return textBoxName.Text; }
        }
    }
}
