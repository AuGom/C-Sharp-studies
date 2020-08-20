using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int conta;
        public double saldo;

        public void Sacar(double val)
        {
            if (this.saldo >= val)
            {
                this.saldo -= val;
                Console.WriteLine("Operacao concluida");
            }
                
            else
                Console.WriteLine("Saldo insuficiente");

        }

        public void Deposito(double val)
        {

            this.saldo += val;
            Console.WriteLine("Operacao concluida");

        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                this.saldo -= valor;
                contaDestino.saldo += valor;
            }
        }
    }

    
}

