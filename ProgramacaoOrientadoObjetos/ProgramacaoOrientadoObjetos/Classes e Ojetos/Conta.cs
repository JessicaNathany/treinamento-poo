namespace ProgramacaoOrientadoObjetos.Classes_e_Ojetos
{
    public class Conta
    {
        private string _cliente;
        private double _valor;

        public Conta(string nomeCliente)
        {
            _cliente = nomeCliente;
        }

        public void Sacar(double valor)
        {
            _valor = _valor - valor;
        }

        public void Depositar(double valor)
        {
            _valor = _valor + valor;
        }

        public double ObtemValor()
        {
            return _valor;
        }

        public string ObtemCliente()
        {
            return _cliente;
        }
    }
}
