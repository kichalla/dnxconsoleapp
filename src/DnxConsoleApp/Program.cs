using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnxConsoleApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            var name = "John";
            Console.WriteLine(name.Normalize().ToUpperInvariant());
        }
    }
}
