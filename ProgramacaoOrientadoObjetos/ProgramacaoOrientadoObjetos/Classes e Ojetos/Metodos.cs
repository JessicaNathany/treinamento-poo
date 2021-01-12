using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadoObjetos.Classes_e_Ojetos
{
    public class Metodos
    {
        public void Execucao()
        {
            Console.WriteLine();

            var conta = new ContaCorrente()
            {
                Agencia = 123,
                Titular = "Jéssica",
                Numero = 8792,
                Saldo = 3000
            };

            var saque = conta.Sacar(2000);


            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da conta do cliente");
            Console.WriteLine();
            Console.WriteLine($"Titular: {conta.Titular}" + "\n" + $"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.Numero}" + "\n" + $"Saldo: {conta.Saldo}");
            Console.ReadKey();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
            }
        }
    }

// retestar
    public class ContaCorrente
    {
        public string Titular;
        public int Agencia;
        public int Numero;
        public double Saldo = 100;


        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            return true;
        }
    }




