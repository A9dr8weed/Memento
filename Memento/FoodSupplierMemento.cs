using System;

namespace Memento
{
    /// <summary>
    /// The Concrete Memento contains the infrastructure for storing the Originator's state.
    /// </summary>
    public class FoodSupplierMemento : IMemento
    {
        private readonly string _name;
        private readonly string _phone;
        private readonly string _address;

        private readonly DateTime _date;

        public FoodSupplierMemento(string name, string phone, string address)
        {
            _name = name;
            _phone = phone;
            _address = address;
            _date = DateTime.Now;
        }

        public string GetAddress()
        {
            return _address;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetName()
        {
            return $"{_date} / \nName: ({_name})";
        }

        public string GetPhone()
        {
            return _phone;
        }
    }
}