using System;

namespace Memento
{
    /// <summary>
    /// The Memento interface provides a way to retrieve the memento's metadata, such as creation date or name.
    /// However, it doesn't expose the Originator's state.
    /// </summary>
    public interface IMemento
    {
        /// <summary>
        /// Method to save memento name.
        /// </summary>
        string GetName();

        /// <summary>
        /// Method to save memento phone.
        /// </summary>
        string GetPhone();

        /// <summary>
        /// Method to save memento address.
        /// </summary>
        string GetAddress();

        /// <summary>
        /// Method to save memento creating date.
        /// </summary>
        DateTime GetDate();
    }
}