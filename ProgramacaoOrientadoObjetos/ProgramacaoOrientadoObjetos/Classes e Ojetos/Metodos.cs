using System;
namespace ProgramacaoOrientadoObjetos.Classes_e_Ojetos
{
    public class Metodos
    {
        public void Execucao()
        {
            /* Depósito */
            //Console.WriteLine();
            //Console.WriteLine("Digite seu nome: " + "\n");
            //var nome = Console.ReadLine();
            //Console.WriteLine("Informe um valor para depósito: " + "\n");

            /* Saque */
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor para saque: " + "\n");

            //var valor = Console.ReadLine();

            
            var valor = Convert.ToDouble(Console.ReadLine()); 

            var conta = new ContaCorrente()
            {
                Agencia = 123,
                Titular = "Jéssica",
                Numero = 8792,
                Saldo = 1000
            };

            //var deposito = conta.Depositar(valorConvert);
            var saque = conta.Sacar(valor);

            // Imprime as informações da conta do cliente(DEPÓSITO)

            //Console.WriteLine("------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Dados da conta do cliente");
            //Console.WriteLine();
            //Console.WriteLine($"Olá {nome}," + "\n" + "seu depósito foi realizado com sucesso!" + "\n" + $"Valor depositado: {valor}" + "\n");
            //Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.Numero}" + "\n" + $"Saldo: {deposito}");
            //Console.ReadKey();
            //Console.WriteLine("------------------------------------");
            //Console.ReadKey();

            /* Imprime as informações da conta do cliente (SAQUE)*/

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
    }

    public class ContaCorrente
    {
        public string Titular;
        public int Agencia;
        public int Numero;
        public double Saldo;

        public double Sacar(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {Saldo} é inferior ao valor do saque {valor}."); 
            }
            else
            {
                Saldo -= valor;
                return Saldo;
            }

            return Saldo;
        }

        public double Depositar(double valor)
        {
            Saldo += valor;

            return Saldo;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {Saldo} é inferior ao valor que deseja transferir. {Saldo}");
            }

            Saldo -= valor;
            contaDestino.Depositar(valor);
            Console.WriteLine($"Transferência realizada com sucesso! Seu saldo é de: {Saldo}");
            return true;
        }
    }
}



