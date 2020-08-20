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
            ContaCorrente conta2 = new ContaCorrente();


            conta1.agencia = 2345;
            conta1.conta = 353621;
            conta1.saldo = 234.56;
            conta1.titular = "augusto";

            conta2.agencia = 2345;
            conta2.conta = 353921;
            conta2.saldo = 2876.9;
            conta2.titular = "luis";

            conta1.Sacar(100);
            Console.WriteLine(conta1.saldo);

            conta1.Deposito(150);
            Console.WriteLine(conta1.saldo);


            conta2.Transferir(230, conta1);
            Console.WriteLine(conta1.saldo);
            Console.WriteLine(conta2.saldo);


            Console.ReadLine();



        }
    }
}
