using System;

namespace ProgramacaoOrientadoObjetos.Encapsulamento
{
    public class Smarthphone: Eletronico
    {
        public Smarthphone(string nome, string marca, string tipo) : base(nome, marca, tipo)
        {
        }

        public Smarthphone() : base("GALAXY", "Sangung", "celular")
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

        public class EncapsulandoDados
        {
            private int Login { get; set; }
            public string Nome { get; set; }
            public decimal Senha { get; private set; }
        }

        public class TestandoEncapsulamento
        {
            EncapsulandoDados dados = new EncapsulandoDados()
            {
                Nome = "Jéh",
            };
            

        }

    }
}
