using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop
{
    class Auto
    {
        public string manufacturer;

        public string brend;

        public DateTime realeseDate;

        public decimal power;

        public Transmission transmission;

        public State state;

        public decimal price;

        public Shop shop;

        public Auto(string manufacturer, string brend, DateTime realeseDate, decimal power, Transmission transmission, State state, decimal price, Shop shop)
        {
            this.manufacturer = manufacturer;
            this.brend = brend;
            this.realeseDate = realeseDate;
            this.power = power;
            this.transmission = transmission;
            this.state = state;
            this.price = price;
            this.shop = shop;
        }

        public override string ToString()
        {
            return String.Format("Производитель: {0} - Марка: {1} - Дата выпуска: {2} - " +
                "Мощность: {3} л.с. - {4} - Состояние: {5} - Стоимость: {6:F2}",
                manufacturer, brend, realeseDate.ToString("dd.MM.yy"), power, 
                transmission.GetString, state.GetString, price);
        }
    }

    class Shop : IContacts
    {
        public string title;

        public string address;

        public List<Auto> autos = new List<Auto>();

        List<string> contacts = new List<string>();

        public Shop(string title, string address)
        {
            this.title = title;
            this.address = address;
        }

        public void AddContact(string s)
        {
            contacts.Add(s);
        }

        public void EditContact(int index, string s)
        {
            contacts[index] = s;
        }

        public void RemoveContact(int index)
        {
            contacts.RemoveAt(index);
        }

        public void ClearContacts()
        {
            contacts.Clear();
        }

        public string[] GetContacts()
        {
            return contacts.ToArray();
        }

        public override string ToString()
        {
            return String.Format("\"{0}\" - Адрес: {1}", title, address);
        }
    }

    class Client : IContacts
    {
        public string lastName;

        public string firstName;

        public string middleName;

        public Transmission transmission;

        public State state;

        public decimal minPower;

        public decimal maxPrice;

        public List<string> brends;

        public List<string> contacts = new List<string>();

        public Client(string lastName, string firstName, string middleName, 
            Transmission.TransmissionEnum transmission, State.StateEnum state, 
            decimal minPower, decimal maxPrice, string[] brends)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.transmission = new Transmission(transmission);
            this.state = new State(state);
            this.minPower = minPower;
            this.maxPrice = maxPrice;
            this.brends = new List<string>(brends);
        }

        public void AddContact(string s)
        {
            contacts.Add(s);
        }

        public void EditContact(int index, string s)
        {
            contacts[index] = s;
        }

        public void RemoveContact(int index)
        {
            contacts.RemoveAt(index);
        }

        public void ClearContacts()
        {
            contacts.Clear();
        }

        public string[] GetContacts()
        {
            return contacts.ToArray();
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", lastName, firstName, middleName);
        }
    }

    interface IContacts
    {
        void AddContact(string s);

        void EditContact(int index, string s);

        void RemoveContact(int index);

        void ClearContacts();

        string[] GetContacts();
    }
}
