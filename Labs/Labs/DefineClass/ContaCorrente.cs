using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.DefineClass
{
    public class ContaCorrente
    {
        private decimal saldo;
        private decimal acumSaldo;
        private int nroOper;
        private string nome;
        private DateTime criacao;
        private DateTime atualizacao;

        public ContaCorrente(string nome)
        {
            this.nome   = nome;
            saldo       = 0;
            criacao     = DateTime.Now;
            acumSaldo   = 0;
            nroOper     = 0;
        }

        public ContaCorrente(string nome, decimal saldo) 
            : this(nome)
        {
            this.saldo = saldo;
        }

        public void Depositar(decimal val)
        {
            saldo += val;
            atualizacao = DateTime.Now;
            acumulaSaldo();
        }

        public void Sacar(decimal val)
        {
            if (val <= saldo)
                saldo -= val;
            atualizacao = DateTime.Now;
            acumulaSaldo();
        }

        #region "get"

        public DateTime DataCriacao
        {
            get { return criacao; }
        }

        public DateTime DataAtualizacao
        {
            get { return atualizacao; }
        }

        public string Nome
        {
            get { return nome; }
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public decimal SaldoMedio
        {
            get
            {
                if (nroOper > 0)
                    return acumSaldo / nroOper;
                else
                    return 0;
            }
        }
        #endregion

        private void acumulaSaldo()
        {
            acumSaldo = acumSaldo + saldo;
            nroOper = nroOper + 1;
        }
    }
}