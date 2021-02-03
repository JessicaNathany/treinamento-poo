using ProgramacaoOrientadoObjetos.Classes_e_Ojetos;
using System;

namespace ProgramacaoOrientadoObjetos.Encapsulamento
{
    public class ExemploEncapsulamento
    {
        /*
         * SELEAD - classe poderá sere instanciada mas não pode ser herdada
         * ABSTRACT - classe não pode ser instanciada
         * INTERNAL - pode ser instanciada e herdada desde que esteejam dentro do mesmo assembly
         * PRIVATE - acesso limitado ao tipo recipiente, ou seja, um método privado só pode ser chamado dentro da classe
         * PROTECTED - permite acesso as classes filhas a qualquer classe externa
         * STATIC - uma classe static não poderá ser instanciada
         * PROTECTED INTERNAL -  são classes limitadas ao assembly ou se não classea que etsão derivadandos daquela classe.
         * PRIVATE PROTECTED -  acesso limitado apenas para as clases que deriavam (herança) ou se não, classes que estão no mesmo assembply
         
          */

        public void Execucao()
        {
            Conta conta = new Conta("Jéssica Nathany");
            conta.Depositar(200);
            conta.Sacar(50);
            Console.WriteLine($"Valor: {conta.ObtemValor()}");
            Console.WriteLine($"Cliente: {conta.ObtemCliente()}");
            Console.ReadLine();
        }

        public void ObterSmartphones()
        {
            var smarthphone = new Smarthphone();
            smarthphone.Ligar();
            smarthphone.Desligar();
            smarthphone.Testar();
            smarthphone.ObtemSmartphone();
        }
    }
}
