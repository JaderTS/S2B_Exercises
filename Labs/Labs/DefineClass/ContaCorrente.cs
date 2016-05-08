using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.DefineClass
{
    class ContaCorrente
    {
        private decimal saldo;

        public void Depositar(decimal val)
        {
            saldo += val;
        }

        public void Sacar(decimal val)
        {
            saldo -= val;
        }

        public decimal Saldo
        {
            get { return saldo; }
        }
    }
}