namespace ProgramacaoOrientadoObjetos.Classes_e_Ojetos.Model
{
    public class Conta
    {
        public int Id { get; set; }

        public int Ag { get; set; }

        public int NumeroConta { get; set; }
    }
    public class ContaPoupanca : Conta
    {
        public TipoConta TipoConta { get; set; }
        public string Banco { get; set; }
    }

    public class ContaCorrente : Conta
    {
        public TipoConta TipoConta { get; set; }
        public string Banco { get; set; }
    }

    public class ContaInvestimento : Conta
    {
        public TipoConta TipoConta { get; set; }
        public string Corretora { get; set; }
    }
    public enum TipoConta
    {
        Poupanca = 1,
        ContaCorrente = 2,
        ContaInvestimento = 3
    }

    public enum TipoBanco
    {
        Fisico = 1,
        Digital = 2
    }
}
