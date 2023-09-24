using System;

namespace GenericType
{
    class Program
    {
        class StoreAnything <T, U, V> //class StoreInt has 2 integers, with set and get functions set to each variable
        {
            public T Var1 { set; get; }
            public U Var2 { set; get; }
            public V Var3 { set; get; }
        }
        
        static void Main(string[] args)
        {
            //create new object of StoreAnything class, passing string type
            StoreAnything<string, int, char> MyVar1 = new StoreAnything<string, int, char> { Var1 = "CS", Var2 = 131, Var3 = '!' };
            
            Console.WriteLine(MyVar1.Var1 + MyVar1.Var2 + MyVar1.Var3); //print new values of var1 and var2 and var3
        }
    }
}
