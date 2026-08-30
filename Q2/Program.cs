using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee dev = new Developer("Zeina", 1200, 10);
            Employee mang = new Manager("Rasha", 1800, 5);
            Console.WriteLine(dev.ToString());
            Console.WriteLine();
            Console.WriteLine(mang.ToString());
        }
    }
}

