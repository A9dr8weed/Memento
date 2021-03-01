using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    /// <summary>
    /// The Caretaker class. This class never examines the contents of any Memento and is responsible for keeping that memento.
    /// </summary>
    public class SupplierMemory
    {
        /// <summary>
        /// Collection of mementos.
        /// </summary>
        private readonly List<IMemento> _mementos = new List<IMemento>();

        /// <summary>
        /// Reference to originator class.
        /// </summary>
        private readonly FoodSupplier _foodSupplier;

        public SupplierMemory(FoodSupplier foodSupplier)
        {
            _foodSupplier = foodSupplier;
        }

        /// <summary>
        /// In this case, the command saves a snapshot of the state of the recipient object before passing the action to it.
        /// </summary>
        public void Backup()
        {
            Console.WriteLine("\nSupplierMemory: Saving Originator's state...");
            _mementos.Add(_foodSupplier.Save());
        }

        /// <summary>
        /// Cancel the action, the command will return the object to its previous state.
        /// </summary>
        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            IMemento memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine($"\nSupplierMemory: Restoring state to: {memento.GetName()}");

            try
            {
                _foodSupplier.RestoreMemento(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        /// <summary>
        /// Show history of changes.
        /// </summary>
        public void ShowHistory()
        {
            Console.WriteLine("\nSupplierMemory: Here's the list of mementos:");

            foreach (IMemento memento in _mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}