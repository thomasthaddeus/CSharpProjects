using System;
using System.Collections;

namespace ConsoleApplication1 {
    class Program {
        private static void Main() {
            ArrayList errands = new ArrayList();       // Declare and initialize.
            errands.Add(new GroceryItem("Apples", 6)); // Add 'Grocery' objects.
            errands.Add(new GroceryItem("Carrots", 3));
            string[] toDo = {"Go to tailors.", "Put air in tire."};
            errands.InsertRange(2, toDo);              // Add string array starting
                                                       // at third position.
            GroceryItem bananas = new GroceryItem("Bananas", 5);
            errands.Insert(1, bananas);                // Add item at 2nd position.
            ShowErrands(errands);                      // Show all items.
            errands.RemoveAt(0);                       // Remove first item.
            errands.Remove(bananas);                   // Remove item by value.
            ShowErrands(errands);                      // Show all items.
            Console.ReadLine();
        }

        private static void ShowErrands(ArrayList errands) {
            Console.WriteLine("* ToDo List *");
            foreach (Object obj in errands) {  // If the object is a 'GroceryItem' item cast it and call its
                                               // Display() method.
                if (obj.GetType() == typeof (GroceryItem)) {
                    GroceryItem groceryItem = (GroceryItem) obj;
                    groceryItem.Display();
                }
                else
                    Console.WriteLine(obj.ToString());
            }
            Console.WriteLine();
        }
    }

    class GroceryItem {
        public string Description { get; set; }
        public int Quantity       { get; set; }

        public GroceryItem(string description, int quantity) {
            Description = description;
            Quantity    = quantity;
        }

        public void Display() {
            Console.WriteLine(Description + ": " + Quantity);
        }
    }
}