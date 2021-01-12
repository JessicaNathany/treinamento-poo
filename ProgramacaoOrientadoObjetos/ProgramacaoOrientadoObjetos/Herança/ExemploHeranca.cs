using System;

namespace ProgramacaoOrientadoObjetos.Herança
{
    public class ExemploHeranca
    {
        /* Exemplo 1 Herança */
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "João da Silva",
                DataNascimento = Convert.ToDateTime("1990/01/01"),
                DataAdmissao = DateTime.Now,
                Registro = "0123456",
            };

            Console.WriteLine();
            Console.WriteLine("..::Relatório Funcionário::.. " + "\n");
            Console.WriteLine($"Nome do funcionário: {funcionario.Nome}");
            Console.WriteLine($"Data de nascimento: {funcionario.DataNascimento}");
            Console.WriteLine($"Data de admissão: {funcionario.DataAdmissao}");
            Console.WriteLine($"Registro: {funcionario.Registro}");
        }
    }

    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}
