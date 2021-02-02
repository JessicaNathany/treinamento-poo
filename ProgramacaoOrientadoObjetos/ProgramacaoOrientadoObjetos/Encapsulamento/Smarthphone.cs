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

        public override void Desligar()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            throw new NotImplementedException();
        }
    }
}
