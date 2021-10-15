using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Beatriz Medina", "000.000.000-00", "Dev");

            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);

            Console.WriteLine("Conta Corrente criada!");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome();
            Console.WriteLine("Agência: {0}", conta.getAgencia());
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns! Seu saldo é de R$ {0}, obrigado por criar sua conta!", conta.getSaldo());
        }
    }
}
