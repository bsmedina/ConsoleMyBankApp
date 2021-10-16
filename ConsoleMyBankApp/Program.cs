using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Beatriz Medina", "000.000.000-00", "Dev");
            Cliente clienteDiego = new Cliente("Diego Lessa", "000.000.000-00", "Desenvolvedor");

            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);
            ContaCorrente contaDiego = new ContaCorrente(clienteDiego, 01, 0002);

            Console.WriteLine("Conta Corrente criada!");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
            Console.WriteLine("Agência: {0}", conta.getAgencia());
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns! Seu saldo inicial é de R$ {0}, obrigado por criar sua conta!", conta.getSaldo());

            double valorDeposito = 100;
            conta.Depositar(valorDeposito);

            Console.WriteLine("Seu saldo atual é R${0}.", conta.getSaldo());

            double valorSaque = 100;
            conta.Sacar(valorSaque);

            Console.WriteLine("Seu saldo atual é R${0}.", conta.getSaldo());

            double valorPix = 150;
            conta.Pix(valorPix, contaDiego);

            //Console.WriteLine("Você recebeu um pix no valor de R${0}. Seu saldo atual é R${1}.", valorPix ,contaDiego.getSaldo());
            Console.WriteLine("Seu saldo atual é R${0}.", contaDiego.getSaldo());

            ContaPoupanca contaPoupanca = new ContaPoupanca(cliente, 01, 0003);

            Console.WriteLine("Titular: {0}", contaPoupanca.getTitular().getNome());
            Console.WriteLine("Agência: {0}", contaPoupanca.getAgencia());
            Console.WriteLine("Conta: {0}", contaPoupanca.getConta());




        }
    }
}
