using System;

namespace Memento
{
    /// <summary>
    /// The Originator class, which is the class for which we want to save Mementos for its state.
    /// </summary>
    public class FoodSupplier
    {
        /// <summary>
        /// Supplier name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Supplier phone number.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Supplier address.
        /// </summary>
        private string _address;

        /// <summary>
        /// Public properties.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Console.WriteLine($"Proprietor:  {_name}");
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                Console.WriteLine($"Phone Number: {_phone}");
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                _address = value;
                Console.WriteLine($"Address: {_address}");
            }
        }

        public FoodSupplier(string name, string phone, string address)
        {
            _name = name;
            _phone = phone;
            _address = address;
        }

        /// <summary>
        /// Saves the current state inside a memento.
        /// </summary>
        /// <returns> Snapshot of the state of the object. </returns>
        public IMemento Save()
        {
            Console.WriteLine("Saving current state\n");

            return new FoodSupplierMemento(_name, _phone, _address);
        }

        /// <summary>
        /// Restores the Originator's state from a memento object.
        /// </summary>
        /// <param name="memento"> Some memento. </param>
        public void RestoreMemento(IMemento memento)
        {
            if (!(memento is FoodSupplierMemento))
            {
                throw new Exception($"Unknown memento class {memento}");
            }

            // Get the saved value.
            Console.WriteLine("\nRestoring previous state\n");
            Name = memento.GetName();
            Phone = memento.GetPhone();
            Address = memento.GetAddress();
        }
    }
}