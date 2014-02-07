using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace anyKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.TreatControlCAsInput = true;
            ConsoleKeyInfo theKey = Console.ReadKey();
            ConsoleKeyInfo anyKey = Console.ReadKey();
            Console.Clear();
            while (anyKey != theKey)
            {
                Console.WriteLine("Press the any key to continue");
                anyKey = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("That was not the any key.");
            }
            Console.Clear();
            Console.WriteLine("That was the any key.");
            Console.ReadLine();
        }
    }
}
