namespace ProgramacaoOrientadoObjetos.Classes_e_Ojetos.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }

    public class Aluno : Pessoa
    {
        public string RA { get; set; }
        public string Curso { get; set; }
        public string Semestre { get; set; }
        public int Idade { get; set; }
    }

    public class Professor : Pessoa
    {
        public string NivelSuperior { get; set; }
        public string Especialidade { get; set; }
        public float Salario { get; set; }
    }
}
