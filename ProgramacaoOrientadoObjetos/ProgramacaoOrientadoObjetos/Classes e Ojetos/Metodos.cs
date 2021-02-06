using System;
namespace ProgramacaoOrientadoObjetos.Classes_e_Ojetos
{
    public class Metodos
    {
        public void Execucao()
        {
            Console.WriteLine(" ..:: Selecione uma opção ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Sacar");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Transferir");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new ContaCorrente().OpcaoSacar();
                    break;

                case '2':
                    new ContaCorrente().OpcaoDepositar();
                    break;

                case '3':
                    new ContaCorrente().OpcaoTransferir();
                    break;
            }
        }
    }

    public class ContaCorrente
    {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public void OpcaoSacar()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor para saque: " + "\n");

            var valor = Convert.ToDouble(Console.ReadLine());

            var conta = new ContaCorrente()
            {
                Agencia = 123,
                Titular = "Jéssica",
                Numero = 8792,
                Saldo = 1000
            };

            var saque = conta.Sacar(valor);

            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da conta do cliente");
            Console.WriteLine();
            Console.WriteLine($"Olá {nome}," + "\n" + "seu saque foi realizado com sucesso!" + "\n" + $"Valor sacado: {valor}" + "\n");
            Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.Numero}" + "\n" + $"Saldo: {saque}");
            Console.ReadKey();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }

        public void OpcaoDepositar()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor para depósito: " + "\n");
            var valor = Convert.ToDouble(Console.ReadLine());

            var conta = new ContaCorrente()
            {
                Agencia = 123,
                Titular = "Jéssica",
                Numero = 8792,
                Saldo = 1000
            };

            var deposito = conta.Depositar(valor);

            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da conta do cliente");
            Console.WriteLine();
            Console.WriteLine($"Olá {nome}," + "\n" + "seu depósito foi realizado com sucesso!" + "\n" + $"Valor depositado: {valor}" + "\n");
            Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.Numero}" + "\n" + $"Saldo: {deposito}");
            Console.ReadKey();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }

        public void OpcaoTransferir()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o número da Agencia: " + "\n");
            var agenciaDestino = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número da Conta: " + "\n");
            var contaDestino = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor para transferência: " + "\n");
            var valor = Convert.ToDouble(Console.ReadLine());

            var conta = new ContaCorrente()
            {
                Agencia = 123,
                Titular = "Jéssica",
                Numero = 8792,
                Saldo = 1000
            };

            var transferir = conta.Transferir(valor, agenciaDestino, contaDestino);

            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da conta do cliente");
            Console.WriteLine();
            Console.WriteLine($"Olá, {nome}");
            Console.WriteLine($"Transferência realizada com sucesso! Seu saldo é de: {conta.Saldo}");
            Console.WriteLine($"Agencia: {contaDestino}" + "\n" + $"Numero: {agenciaDestino}" + "\n" + $"Saldo: {transferir}");
            Console.ReadKey();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }

        private double Sacar(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {Saldo} é inferior ao valor do saque {valor}.");
                return Saldo;
            }

            Saldo -= valor;
            return Saldo;
        }
        private double Depositar(double valor)
        {
            Saldo += valor;

            return Saldo;
        }
        private bool Transferir(double valor, int agencia, int conta)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {Saldo} é inferior ao valor que deseja transferir. {Saldo}");
                return false;
            }

            Saldo -= valor;
            return true;
        }
    }
}



