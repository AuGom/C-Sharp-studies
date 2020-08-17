using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();

            conta1.agencia = 2345;
            conta1.conta = 353621;
            conta1.saldo = 234.56;
            conta1.titular = "augusto";


        }
    }
}
