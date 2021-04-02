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
    public partial class SearchClients : Form
    {
        public SearchClients()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.Items.Clear();
            if (clientsList.SelectedItem != null)
            {
                Client c = clientsList.SelectedItem as Client;
                info.Items.Add(String.Format("Марки: {0}", string.Join(", ", c.brends.ToArray())));
                info.Items.Add(String.Format("Коробка передач: {0}", c.transmission.GetString));
                info.Items.Add(String.Format("Состояние: {0}", c.state.GetString));
                info.Items.Add(String.Format("Минимальная мощность: {0}", c.minPower));
                info.Items.Add(String.Format("Максимальная стоимость: {0}", c.maxPrice));

                info.Items.Add("Контакты:");
                foreach (string s in c.GetContacts())
                    info.Items.Add(s);
            }
        }
    }
}
