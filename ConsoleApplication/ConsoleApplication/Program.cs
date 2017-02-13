using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        private static string format = "Hello {0},{1}{2}";
        static void Main(string[] args)
        {
            // get first Name
            Console.Write("Please enter your firstname :--");
            string Name = Console.ReadLine();
            // get first last Name
            Console.Write("Please enter your lastename :--");
            string LName = Console.ReadLine();
            // print all input 
            Console.WriteLine(string.Format(format, Name, Environment.NewLine, Name + LName));
            // wait for next
            Console.Read();
        }
    }
}
