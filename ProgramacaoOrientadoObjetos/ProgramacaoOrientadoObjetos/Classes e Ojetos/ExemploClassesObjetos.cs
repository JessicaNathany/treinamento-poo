using System;

namespace ProgramacaoOrientadoObjetos.Classes_e_Ojetos
{
    public class ExemploClassesObjetos
    {
        public class Conta
        {
            public int Ag { get; set; }
            public string Banco { get; set; }
            public int NumeroConta { get; set; }
            public double Saldo { get; set; }
        }

        public class Cliente
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
        }

        public void Execucao()
        {
            var conta = new Conta()
            {
                Ag = 006,
                Banco = "Banco dos Devs",
                NumeroConta = 123,
                Saldo = 10000
            };

            var cliente = new Cliente()
            {
                Nome = "Jéssica Nathany",
                Idade = 30,
                Email = "jessicanathany.web@gmail.com",
                Telefone = "55+(11)999999"
            };

            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados Bancários");
            Console.WriteLine();
            Console.WriteLine($"Banco: {conta.Banco}" + "\n" + $"Agência: {conta.Ag}" + "\n" +  $"Número da conta: {conta.NumeroConta}" + "\n" + $"Saldo da conta: {conta.Saldo}");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados do Cliente");
            Console.WriteLine();
            Console.WriteLine($"Nome: {cliente.Nome}" + "\n" + $"Idade: {cliente.Idade}" + "\n" + $"Email: {cliente.Email}" + "\n" + $"Telefone: {cliente.Telefone}");
            Console.ReadKey();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }
    }
}
