using System;

namespace Odev.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Engin");
            Console.WriteLine(myDictionary.Length);

            myDictionary.Add(2, "Berkay");
            Console.WriteLine(myDictionary.Length);

            foreach (var value in myDictionary.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
