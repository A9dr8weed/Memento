using System;

namespace Memento
{
    public static class Program
    {
        private static void Main()
        {
            //Here's a new supplier for our restaurant.
            FoodSupplier supplier = new FoodSupplier("Harold Karstark", "(482) 555-1172", "S Main St. Nowhere, KS");

            // Let's store that entry in our database.
            SupplierMemory memory = new SupplierMemory(supplier);

            memory.Backup();
            supplier.Name = "A";

            memory.Backup();
            supplier.Name = "B";

            memory.Backup();
            supplier.Name = "C";

            Console.WriteLine();
            memory.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            memory.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            memory.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            memory.Undo();
        }
    }
}