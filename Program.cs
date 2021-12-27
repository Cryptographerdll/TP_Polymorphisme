using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TP_Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book(121, "C# in Depth", "John Mack", (float)12.3, 450);

            Console.WriteLine(b.ToString());

            if (b.Comparer("C# in Depth"))
                Console.WriteLine("it's the book title");
            else
                Console.WriteLine("it's Not the book title");

            if (b.Comparer((float)12.3))
                Console.WriteLine("it's the same price ");
            else
                Console.WriteLine("it's not the same price");


            Console.ReadKey();
            
        }
    }
}
