using Labs.DefineClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Lab_4_DefineClass
    {
        static void Main_4(String[] args)
        {
            //ContaCorrente minhaConta = new ContaCorrente();
            //minhaConta.Depositar(1000);
            //minhaConta.Sacar(250);

            ContaCorrente minhaConta = new ContaCorrente();
            Console.WriteLine(minhaConta.Saldo);
            Console.WriteLine("");
            minhaConta.Depositar(1000);
            Console.WriteLine(minhaConta.Saldo);
            Console.WriteLine("");
            minhaConta.Sacar(250);
            Console.WriteLine(minhaConta.Saldo);
            Console.ReadLine();
        }
    }
}
