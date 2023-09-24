using System;
using System.Collections.Generic;

namespace Starter {
    public class Program {
        public static void Main() {
            List<string> collection = new List<string>();
            AddItems(collection);
            ShowItems(collection);
            RemoveItems(collection);
            ShowItems(collection);
            Console.ReadLine();
        }

        public static void AddItems(List<string> collection) {
            collection.Add("Al");           // Add 'Al'.
            collection.Add("Ed");           // Add 'Ed'.
            collection.Insert(1, "Bob");    // Place 'Bob' at 2nd position.
            List<string> subCollection = new List<string>();
            subCollection.Add("Cal");
            subCollection.Add("Dora");
            // Insert list with 'Cal' and 'Dora' at 3rd position after 'Bob'.
            collection.InsertRange(2, subCollection);
        }

        private static void ShowItems(List<string> collection) {
            foreach (string letter in collection)
                Console.Write(letter + ", ");
            Console.WriteLine();
        }

        public static void RemoveItems(List<string> collection) {
            collection.Remove("Dora"); // Remove 'Dora' by value.
            collection.RemoveAt(0);    // Remove first item.
        }
    }
}