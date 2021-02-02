using System;
namespace ProgramacaoOrientadoObjetos.Herança
{
    /* # CLASSE
     
     - Uma classe abstrata é uma classe que não pode ser instanciada. Você não pode criar um objeto a partir de uma classe abstrata.
     - Uma classe abstrata pode ser herdada e geralmente serve como classe base para outras classes.
     - Uma classe abstrata pode conter métodos abstratos e métodos comuns. Uma classe abstrata também podem possuir construtores, propriedades, indexadores e eventos.
     - Uma classe abstrata não pode ser estática (static). Uma classe abstrata não pode ser selada (sealed).
     - Uma classe abstrata pode herdar de outra classe abstrata.
    
      # MÉTODOS     
      - Um método abstrato é um método que não possui implementação na classe abstrata. Um método abstrato possui somente a definição de sua assinatura. A sua implementação deve ser feita na classe derivada.
      - Um método abstrato é um método virtual e deve ser implementado usando o modificador override.
      - Um método abstrato somente pode existir em uma classe abstrata.
      - Um método abstrato não pode usar os modificadores static e virtual.
   */
    public class Abstracao
    {
        public void Execucao()
        {
            var quadrado = new Quadrado();
            Console.WriteLine(quadrado.Descricao());
            Console.WriteLine("Informe o valor do lado do quadrado em metros.");
            quadrado.Lado = Convert.ToInt32(Console.ReadLine());
            quadrado.CalcularArea();
            quadrado.CalcularPerimetro();
            Console.WriteLine("A área do quadrado é : " + quadrado.Area + " m2 ");
            Console.WriteLine("O perímetro do quadrado é : " + quadrado.Perimetro + " m ");
            Console.ReadKey();
        }

        public abstract class Eletrodomestico
        {
            private readonly string _voltagem;
            private readonly bool _ligar;

            public Eletrodomestico(bool ligar, string voltagem)
            {
                _voltagem = voltagem;
                _ligar = ligar;
            }

            public abstract void Sacar();
            public abstract void Desligar();
        }

        #region Exemplo sem Abstração
        public class Funcionario
        {
            public  string Nome { get; set; }
            public string CPF { get; set; }
            public double Salario { get; set; }

            public double ObtemBonificacao()
            {
                return Salario * 12;
            }

            // realiza outras ações
        }

        public class ControlarBonificacoes
        {
            public double TotalBonificacoes = 0;

            /* 
             * Método RegistraBonificacao recebe qualquer referência do tipo funcionário, isto é, qualquer objeto do tipo Funcionarário e qualquer um dos seus sub tipos
               Porém, dar o new ao Funcionário pode não fazer sentido para essa situação., pois não queremos receber um obj do tipo Funcionario, mas ao certo é esta classe ser referência
               seja um Gerente ou um Diretor ou até mesmo um funcionário. Precisamos abstrair essa classe e deixa-la mais concreta.
                 */
            public void RegistraBonificacao(Funcionario funcionario)
            {
                Console.WriteLine($"Adicionando bonificação do  funcionario: ", funcionario.Nome);
                TotalBonificacoes += funcionario.ObtemBonificacao();
            }

            public double ObtemTotalBonificacoes()
            {
                return TotalBonificacoes;
            }
        }

        /*
         * A classe abstrata é instanciavel, ou seja, qunado utilizamos o 
         * abstract estamos dizendo que essa classe não pode ser instanciada.
         */

        #endregion

        #region Exemplo usando abstração
        public abstract class Forma
        {
            public double Area { get; set; }
            public string Cor { get; set; }
            public double Perimetro { get; set; }
         
            public abstract void CalcularArea();
            public abstract void CalcularPerimetro();
            public string Descricao()
            {
                return "Sou a classe abstrata Forma.";
            }
        }

        public class Quadrado : Forma
        {
            public double Lado  { get; set; }

            public override void CalcularArea()
            {
                Area = Lado * Lado;
            }

            public override void CalcularPerimetro()
            {
                Perimetro = 4 * Lado;
            }
        }

        #endregion
    }
}
