using System;

namespace ProgramacaoOrientadoObjetos.Encapsulamento
{
    public class Smarthphone : Eletronico
    {
        public Smarthphone(string nome, string marca) : base(nome, marca)
        {

        }

        public Smarthphone() : base("Galaxy", "Sangung")
        {

        }

        private static void ObterModeloAndroid() { }

        private static void ObterModeloIOS() { }

        public override void Desligar()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            throw new NotImplementedException();
        }

        public void ObtemSmartphone()
        {
            ObterModeloAndroid();
            ObterModeloIOS();
        }
    }
}
