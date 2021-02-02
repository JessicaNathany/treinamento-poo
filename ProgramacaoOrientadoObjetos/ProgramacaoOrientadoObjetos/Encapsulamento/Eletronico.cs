namespace ProgramacaoOrientadoObjetos.Encapsulamento
{
    public abstract class Eletronico
    {
        private readonly string _nome;
        private readonly string _marca;

        public Eletronico(string nome, string marca)
        {
            _nome = nome;
            _marca = marca;
        }

        public abstract void Ligar();
        public abstract void Desligar();

        public virtual void Testar()
        {
            // teste do celular
        }
    }
}
