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
    public partial class AddEditClient : Form
    {
        public AddEditClient()
        {
            InitializeComponent();
            transmission.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStringForm form = new AddStringForm("Марка");
            if (form.ShowDialog() == DialogResult.OK && form.contact.Text != "")
                brends.Items.Add(form.contact.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (brends.SelectedItem != null)
                brends.Items.Remove(contacts.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStringForm form = new AddStringForm();
            if (form.ShowDialog() == DialogResult.OK && form.contact.Text != "")
                contacts.Items.Add(form.contact.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (contacts.SelectedItem != null)
                contacts.Items.Remove(contacts.SelectedItem);
        }
    }
}
