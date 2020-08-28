using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace JediMindTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, byte> persons = new Dictionary<string, byte>();
            //adding my name to the dictionary
            persons.Add("Kent Pedersen", 42);
            persons.Add("Jørgen Hansen", 48);
            persons.Add("Trine Sørensen", 29);
            

            //printing the content of the dictionary to Console
                Console.WriteLine("Print the names");
            foreach (KeyValuePair<string, byte> pair in persons)
            {
                Console.WriteLine("Name: " + pair.Key + " Age: " + pair.Value);
            }
            Console.WriteLine();

            //Changing the value of the key "Kent Pedersen"
            persons["Kent Pedersen"] = 41;
  
            //printing the new content of the dictionary to Console
                Console.WriteLine("Print the names after changing the value of Kent Pedersen");
            foreach (KeyValuePair<string, byte> pair in persons)
            {
                Console.WriteLine("Name: " + pair.Key + " Age: " + pair.Value);
            }
            Console.WriteLine();

            //Removing a key with its value
            persons.Remove("Jørgen Hansen");
          
            //printing the new content of the dictionary to console by using var in the foreach loop
                Console.WriteLine("Print the names after removing Jørgen Hansen and using var to run throug loop");
            foreach (var pair in persons)
            {
                Console.WriteLine("Name: " + pair.Key + " Age: " + pair.Value);
            }
            Console.WriteLine();

        }


    }
}
