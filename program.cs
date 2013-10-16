using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anyKey
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press the any key to continue");
                Console.ReadKey();
                Console.WriteLine("That was not the any key.");
            }
            Console.ReadLine();
        }
    }
}
