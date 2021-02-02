using System;

namespace ProgramacaoOrientadoObjetos.Encapsulamento
{
    public class ExemploEncapsulamento
    {
        public void Execucao()
        {
            Console.WriteLine("Exemplo do encapsulamento.");
        }

        public void ServirCafe()
        {
            var smarthphone = new Smarthphone();
            smarthphone.Ligar();
            smarthphone.Desligar();
            smarthphone.Testar();
            smarthphone.ObtemSmartphone();
        }
    }
}
