using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 910.25;
            Console.WriteLine(salary);
            double num = 15 / 2.0; // one of the values must be in the float format so "num" can assume the same float format
            Console.WriteLine(num);

            int newSalary = Convert.ToInt32(salary);
            Console.WriteLine(newSalary);

            //long => 64bits integer
            //short => 16bits integer

            Console.ReadLine();
        }
    }
}
