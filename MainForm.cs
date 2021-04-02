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
    public partial class MainForm : Form
    {
        List<Shop> shops = new List<Shop>();
        List<Client> clients = new List<Client>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            autosList.Items.Clear();
            if (tabControl1.SelectedIndex == 0)
            {
                panel3.Visible = true;
                if (shopList.SelectedItem != null)
                    autosList.Items.AddRange((shopList.SelectedItem as Shop).autos.ToArray());
            }
            else
            {
                panel3.Visible = false;
                if (clientsList.SelectedItem != null)
                {
                    Client c = clientsList.SelectedItem as Client;
                    autosList.Items.Add(String.Format("Марки: {0}", string.Join(", ", c.brends.ToArray())));
                    autosList.Items.Add(String.Format("Коробка передач: {0}", c.transmission.GetString));
                    autosList.Items.Add(String.Format("Состояние: {0}", c.state.GetString));
                    autosList.Items.Add(String.Format("Минимальная мощность: {0}", c.minPower));
                    autosList.Items.Add(String.Format("Максимальная стоимость: {0}", c.maxPrice));

                    autosList.Items.Add("Контакты:");
                    foreach (string s in c.GetContacts())
                        autosList.Items.Add(s);
                }
            }
        }

        private void clientsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            autosList.Items.Clear();
            if (clientsList.SelectedItem != null)
            {
                Client c = clientsList.SelectedItem as Client;
                autosList.Items.Add(String.Format("Марки: {0}", string.Join(", ", c.brends.ToArray())));
                autosList.Items.Add(String.Format("Коробка передач: {0}", c.transmission.GetString));
                autosList.Items.Add(String.Format("Состояние: {0}", c.state.GetString));
                autosList.Items.Add(String.Format("Минимальная мощность: {0}", c.minPower));
                autosList.Items.Add(String.Format("Максимальная стоимость: {0}", c.maxPrice));

                autosList.Items.Add("Контакты:");
                foreach (string s in c.GetContacts())
                    autosList.Items.Add(s);
            }
        }

        private void shopList_SelectedIndexChanged(object sender, EventArgs e)
        {
            autosList.Items.Clear();
            if (shopList.SelectedItem != null)
                autosList.Items.AddRange((shopList.SelectedItem as Shop).autos.ToArray());
        }

        private void addShop_Click(object sender, EventArgs e)
        {
            AddEditShop form = new AddEditShop();
            form.Text = "Добавить магазин";
            try
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string title = form.title.Text;
                    string address = form.address.Text;
                    string[] contacts = form.contacts.Items.Cast<string>().ToArray();
                    if (title == "" || address == "" || contacts.Length == 0)
                        throw new ArgumentException("Были введены не все данные");
                    Shop s = new Shop(title, address);
                    foreach (string i in contacts)
                        s.AddContact(i);
                    shops.Add(s);

                    shopList.Items.Clear();
                    shopList.Items.AddRange(shops.ToArray());
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editShop_Click(object sender, EventArgs e)
        {
            if (shopList.SelectedItem == null)
                return;

            AddEditShop form = new AddEditShop();
            Shop shop = shops[shopList.SelectedIndex];
            form.Text = "Изменить магазин";
            form.accept.Text = "Применить";
            form.title.Text = (shopList.SelectedItem as Shop).title;
            form.address.Text = (shopList.SelectedItem as Shop).address;
            form.contacts.Items.AddRange((shopList.SelectedItem as Shop).GetContacts());
            try
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string title = form.title.Text;
                    string address = form.address.Text;
                    string[] contacts = form.contacts.Items.Cast<string>().ToArray();
                    if (title == "" || address == "" || contacts.Length == 0)
                        throw new ArgumentException("Были введены не все данные");
                    shop.title = title;
                    shop.address = address;
                    shop.ClearContacts();
                    foreach (string i in contacts)
                        shop.AddContact(i);

                    shopList.Items.Clear();
                    shopList.Items.AddRange(shops.ToArray());
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteShop_Click(object sender, EventArgs e)
        {
            if (shopList.SelectedItem == null)
                return;
            shops.Remove(shopList.SelectedItem as Shop);

            shopList.Items.Clear();
            shopList.Items.AddRange(shops.ToArray());
        }

        private void addAuto_Click(object sender, EventArgs e)
        {
            if (shopList.SelectedItem == null)
                return;

            AddEditAuto form = new AddEditAuto();
            form.Text = "Добавить автомобиль";
            try
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string manufacturer = form.manufacturer.Text;
                    string brend = form.brend.Text;
                    DateTime releaseDate = form.releaseDate.Value;
                    decimal power = form.power.Value;
                    Transmission transmission = Transmission.GetFromString((string)form.transmission.SelectedItem);
                    decimal distance;
                    State state;
                    if (decimal.TryParse(form.state.Text, out distance))
                        state = State.GetFromValue(distance);
                    else
                        state = State.GetFromString(form.state.Text);
                    decimal price = form.price.Value;
                    if (manufacturer == "" || brend == "")
                        throw new ArgumentException("Были введены не все данные");
                    Auto auto = new Auto(manufacturer, brend, releaseDate, power, transmission, state, price, shopList.SelectedItem as Shop);
                    (shopList.SelectedItem as Shop).autos.Add(auto);

                    autosList.Items.Clear();
                    autosList.Items.AddRange((shopList.SelectedItem as Shop).autos.ToArray());
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editAuto_Click(object sender, EventArgs e)
        {
            if (shopList.SelectedItem == null || autosList.SelectedItem == null)
                return;

            AddEditAuto form = new AddEditAuto();
            Auto auto = shops[shopList.SelectedIndex].autos[autosList.SelectedIndex];
            form.manufacturer.Text = auto.manufacturer;
            form.brend.Text = auto.brend;
            form.releaseDate.Value = auto.realeseDate;
            form.power.Value = auto.power;
            form.transmission.SelectedIndex = (int)auto.transmission.transmission - 1;
            form.state.Text = auto.state.state == State.StateEnum.New ? "Новый" : auto.state.distance.ToString();
            form.price.Value = auto.price;
            form.Text = "Изменить автомобиль";
            try
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string manufacturer = form.manufacturer.Text;
                    string brend = form.brend.Text;
                    DateTime releaseDate = form.releaseDate.Value;
                    decimal power = form.power.Value;
                    Transmission transmission = Transmission.GetFromString((string)form.transmission.SelectedItem);
                    decimal distance;
                    State state;
                    if (decimal.TryParse(form.state.Text, out distance))
                        state = State.GetFromValue(distance);
                    else
                        state = State.GetFromString(form.state.Text);
                    decimal price = form.price.Value;

                    if (manufacturer == "" || brend == "")
                        throw new ArgumentException("Были введены не все данные");
                    auto.manufacturer = manufacturer;
                    auto.brend = brend;
                    auto.realeseDate = releaseDate;
                    auto.power = power;
                    auto.transmission = transmission;
                    auto.state = state;
                    auto.price = price;

                    autosList.Items.Clear();
                    autosList.Items.AddRange((shopList.SelectedItem as Shop).autos.ToArray());
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteAuto_Click(object sender, EventArgs e)
        {
            if (shopList.SelectedItem == null || autosList.SelectedItem == null)
                return;
            (shopList.SelectedItem as Shop).autos.Remove(autosList.SelectedItem as Auto);

            autosList.Items.Clear();
            autosList.Items.AddRange(shops.ToArray());
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddEditClient form = new AddEditClient();
            form.Text = "Добавить клиента";
            try
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string lastName = form.lastName.Text;
                    string firstName = form.firstName.Text;
                    string middleName = form.middleName.Text;
                    decimal power = form.power.Value;
                    decimal price = form.price.Value;
                    string[] brends = form.brends.Items.Cast<string>().ToArray();
                    string[] contacts = form.contacts.Items.Cast<string>().ToArray();
                    if (lastName == "" || firstName == "" || middleName == "" || brends.Length == 0 || contacts.Length == 0)
                        return;
                    Client client = new Client(lastName, firstName, middleName,
                        (Transmission.TransmissionEnum)(form.transmission.SelectedIndex + 1),
                        form.newOrOld.Checked ? State.StateEnum.New : State.StateEnum.Old,
                        power, price, brends);
                    foreach (string i in contacts)
                        client.AddContact(i);
                    clients.Add(client);

                    clientsList.Items.Clear();
                    clientsList.Items.AddRange(clients.ToArray());
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            if (clientsList.SelectedItem == null)
                return;

            AddEditClient form = new AddEditClient();
            Client client = clients[clientsList.SelectedIndex];
            form.lastName.Text = client.lastName;
            form.firstName.Text = client.firstName;
            form.middleName.Text = client.middleName;
            form.power.Value = client.minPower;
            form.price.Value = client.maxPrice;
            form.transmission.SelectedIndex = (int)client.transmission.transmission - 1;
            form.newOrOld.Checked = (int)client.state.state == 2;
            form.brends.Items.AddRange((clientsList.SelectedItem as Client).brends.ToArray());
            form.contacts.Items.AddRange((clientsList.SelectedItem as Client).GetContacts());
            form.Text = "Изменить клиента";
            form.accept.Text = "Применить";
            try
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string lastName = form.lastName.Text;
                    string firstName = form.firstName.Text;
                    string middleName = form.middleName.Text;
                    decimal power = form.power.Value;
                    decimal price = form.price.Value;
                    string[] brends = form.brends.Items.Cast<string>().ToArray();
                    string[] contacts = form.contacts.Items.Cast<string>().ToArray();
                    if (lastName == "" || firstName == "" || middleName == "" || brends.Length == 0 || contacts.Length == 0)
                        return;
                    
                    client.lastName = lastName;
                    client.firstName = firstName;
                    client.middleName = middleName;
                    client.minPower = power;
                    client.maxPrice = price;
                    client.transmission = new Transmission((Transmission.TransmissionEnum)(form.transmission.SelectedIndex + 1));
                    client.state = new State(form.newOrOld.Checked ? State.StateEnum.New : State.StateEnum.New | State.StateEnum.Old);
                    client.brends.Clear();
                    client.brends.AddRange(brends);
                    client.ClearContacts();
                    foreach (string i in contacts)
                        client.AddContact(i);

                    clientsList.Items.Clear();
                    clientsList.Items.AddRange(clients.ToArray());

                    autosList.Items.Clear();
                    autosList.Items.Add(String.Format("Марки: {0}", string.Join(", ", client.brends.ToArray())));
                    autosList.Items.Add(String.Format("Коробка передач: {0}", client.transmission.GetString));
                    autosList.Items.Add(String.Format("Состояние: {0}", client.state.GetString));
                    autosList.Items.Add(String.Format("Минимальная мощность: {0}", client.minPower));
                    autosList.Items.Add(String.Format("Максимальная стоимость: {0}", client.maxPrice));

                    autosList.Items.Add("Контакты:");
                    foreach (string s in client.GetContacts())
                        autosList.Items.Add(s);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            if (clientsList.SelectedItem == null)
                return;
            clients.Remove(clientsList.SelectedItem as Client);

            clientsList.Items.Clear();
            clientsList.Items.AddRange(shops.ToArray());
        }

        private void searchAuto_Click(object sender, EventArgs e)
        {
            if (shopList.SelectedItem == null || autosList.SelectedItem == null)
                return;
            Auto auto = autosList.SelectedItem as Auto;
            SearchClients form = new SearchClients();
            form.clientsList.Items.AddRange(clients
                .Where(c =>
                {
                    if (c.maxPrice < auto.price)
                        return false;
                    if (c.minPower > auto.power)
                        return false;
                    if ((c.transmission.transmission & auto.transmission.transmission) == 0)
                        return false;
                    if ((c.state.state & auto.state.state) == 0)
                        return false;
                    if (!c.brends.Any(b => b.ToLower() == auto.brend.ToLower()))
                        return false;
                    return true;
                }).ToArray());
            form.ShowDialog();
        }
    }
}
