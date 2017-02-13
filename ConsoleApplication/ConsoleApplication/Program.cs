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
            Console.Write("Please enter your firstname :--");
            string Name = Console.ReadLine();
            Console.Write("Please enter your lastename :--");
            string LName = Console.ReadLine();
            Console.WriteLine(string.Format(format, Name, Environment.NewLine, Name + LName));
            Console.Read();
        }
    }
}
