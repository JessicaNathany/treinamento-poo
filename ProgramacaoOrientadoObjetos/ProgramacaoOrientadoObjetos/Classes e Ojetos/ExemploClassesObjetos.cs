using System;
using ProgramacaoOrientadoObjetos.Classes_e_Ojetos.Model;
using System.Collections.Generic;

namespace ProgramacaoOrientadoObjetos.Classes_e_Ojetos
{
    public class ExemploClassesObjetos
    {
        List<Professor> listaProfessores = new List<Professor>();
        List<Aluno> listaAlunos = new List<Aluno>();
        public List<Professor> BuscaProfessores()
        {
            listaProfessores = new List<Professor>()
            {
                new Professor
                {
                    Id = 1,
                    Nome = "Rodolfo",
                    Especialidade = "Aplicações Web",
                    NivelSuperior = "Pós-Graduado",
                    Salario = 10000,
                    Telefone = "962456699"
                },

                new Professor
                {
                    Id = 1,
                    Nome = "Diego",
                    Especialidade = "Machine Learning",
                    NivelSuperior = "Mestrado",
                    Salario = 10000,
                    Telefone = "962456699"
                },

                new Professor
                {
                    Id = 1,
                    Nome = "Carla",
                    Especialidade = "UX",
                    NivelSuperior = "Mestrado",
                    Salario = 10000,
                    Telefone = "962456699"
                }
            };

            return listaProfessores;
        }

        public List<Aluno> BuscaAlunos()
        {
            listaAlunos = new List<Aluno>()
            {
                new Aluno
                {
                    Id = 1,
                    RA = "38826",
                    Nome = "Maria",
                    Curso = "Sistemas de Informação",
                    Idade = 21,
                    Semestre = "3º",
                    Telefone = "00000000"
                },

                new Aluno
                {
                    Id = 1,
                    RA = "38827",
                    Nome = "Bruna",
                    Curso = "Inteligência Artificial",
                    Idade = 23,
                    Semestre = "1º",
                    Telefone = "00000000"
                },

                 new Aluno
                {
                    Id = 1,
                    RA = "38826",
                    Nome = "Carlos",
                    Curso = "Ciência de Dados",
                    Idade = 26,
                    Semestre = "4º",
                    Telefone = "00000000"
                },
            };

            return listaAlunos;
        }

        public void Execucao()
        {
            var listaProfessores = new List<Professor>();

            Console.WriteLine("Selecione a busca que deseja fazer: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Professores");
            Console.WriteLine();
            Console.WriteLine("2 - Alunos");
            Console.WriteLine();

            var opcao = Console.ReadKey();

            // tentar com if e retornar a lista correspondente

            switch (opcao.KeyChar)
            {
                case '1':
                    new ExemploClassesObjetos().BuscaProfessores();
                    break;

                case '2':
                    new ExemploClassesObjetos().BuscaAlunos();
                    break;
            }
            
            Console.WriteLine(listaProfessores);
        }
    }
}
