using ProgramacaoOrientadoObjetos.Classes_e_Ojetos;
using ProgramacaoOrientadoObjetos.Encapsulamento;
using ProgramacaoOrientadoObjetos.Herança;
using ProgramacaoOrientadoObjetos.Polimorfismo;
using System;

namespace ProgramacaoOrientadoObjetos
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(" ..:: Selecione uma opção ::..");
            Console.WriteLine();
            Console.WriteLine("0 - Classes e Objetos");
            Console.WriteLine("1 - Métodos");
            Console.WriteLine("2 - Encapsulamento");
            Console.WriteLine("3 - Herança - Interface e Implementação");
            Console.WriteLine("4 - Polimorfismo");

            var opcao = Console.ReadKey();

            switch(opcao.KeyChar)
            {
                case '0':
                    new ExemploClassesObjetos().Execucao();
                    break;

                case '1':
                    new Metodos().Execucao();
                    break;

                case '2':
                    new ExemploEncapsulamento().Execucao();
                    break;

                case '3':
                    new ExemploHeranca().Execucao();
                    break;

                case '4':
                    new ExemploPolimorfismo().Execucao();
                    break;
            }
        }
    }
}


    
