using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoShop
{
    public partial class AddStringForm : Form
    {
        public AddStringForm()
        {
            InitializeComponent();
        }

        public AddStringForm(string s)
        {
            InitializeComponent();
            label1.Text = s;
        }
    }
}
