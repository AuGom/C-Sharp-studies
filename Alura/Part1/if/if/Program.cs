using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            int quant = 2;
            if (age >= 18)
            {
                Console.WriteLine("maior");
            }
            else if(quant>=2)
            {
                Console.WriteLine("acompanhado");
            }
            else
            {
                Console.WriteLine("menor");
            }
            Console.ReadLine();
        }
    }
}
