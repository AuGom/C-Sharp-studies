using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 1000;
            int mes = 1;
            //for(int mes=1;mes<13;mes++)

            while (mes < 13)
            {
                valor += valor * 0.0036;
                Console.WriteLine("apos " + mes + " meses: "+valor);
                mes++;
            }


            Console.ReadLine();
        }
    }
}
