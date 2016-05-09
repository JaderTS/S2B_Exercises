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
        static void Main(string[] args)
        {
            //ContaCorrente minhaConta = new ContaCorrente();
            //minhaConta.Depositar(1000);
            //minhaConta.Sacar(250);

            //ContaCorrente minhaConta = new ContaCorrente();
            //Console.WriteLine(minhaConta.Saldo);
            //Console.WriteLine("");
            //minhaConta.Depositar(1000);
            //Console.WriteLine(minhaConta.Saldo);
            //Console.WriteLine("");
            //minhaConta.Sacar(250);
            //Console.WriteLine(minhaConta.Saldo);
            //Console.ReadLine();

            ContaCorrente minhaConta = new ContaCorrente("João");
            Console.WriteLine("Data de criação: " + minhaConta.DataCriacao);
            Console.WriteLine("Movimentações conta: " + minhaConta.Nome);
            Console.WriteLine(minhaConta.Saldo);
            System.Threading.Thread.Sleep(2000);

            minhaConta.Depositar(100);
            Console.WriteLine("Atualizada em: " + minhaConta.DataAtualizacao);
            Console.WriteLine(minhaConta.Saldo);
            System.Threading.Thread.Sleep(2000);

            minhaConta.Sacar(50);
            Console.WriteLine("Atualizada em: " + minhaConta.DataAtualizacao);
            Console.WriteLine(minhaConta.Saldo);

            Console.WriteLine("Saldo médio: " + minhaConta.SaldoMedio);

            Console.ReadLine();
        }
    }
}
