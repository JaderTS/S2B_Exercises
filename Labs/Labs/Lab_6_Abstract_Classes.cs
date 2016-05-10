using Labs.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Lab_6_Abstract_Classes
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente("Fulano");
            DateTime t = new DateTime(2009, 10, 21);
            ContaPoupanca conta2 = new ContaPoupanca(0.5M, t, "Beltrano");

            Console.WriteLine("Conta criada: " + conta1);
            Console.WriteLine("Conta criada: " + conta2);

            conta1.Depositar(100);
            conta2.Depositar(200);

            Console.WriteLine(conta1.Id + " - R$ " + conta1.Saldo);
            Console.WriteLine(conta2.Id + " - R$ " + conta2.Saldo);
        }
    }
}
