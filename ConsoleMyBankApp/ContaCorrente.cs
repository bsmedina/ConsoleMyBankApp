using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyBankApp
{
    class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int conta;

        private double saldo = 100.00;

        public ContaCorrente(Cliente titular, int agencia, int conta)
        {
            this.setTitular(titular);
            this.setAgencia(agencia);
            this.setConta(conta);
        }

        public Cliente getTitular()
        {
            return this.titular;
        }

        public void setTitular(Cliente titular)
        {
           this.titular = titular;
        }

        public int getAgencia()
        {
            return this.agencia;
        }

        public void setAgencia(int agencia)
        {
           this.agencia = agencia;
        }

        public int getConta()
        {
            return this.conta;
        }

        public void setConta(int conta)
        {
           this.conta = conta;
        }

        public double getSaldo()
        {
            return this.saldo;
        }

    }
}
