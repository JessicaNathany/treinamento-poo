using System;
namespace ProgramacaoOrientadoObjetos.Polimorfismo
{
    public class ExemploPolimorfismo
    {
        public void Execucao()
        {
            var quadrado = new Quadrado();
            Console.WriteLine(quadrado.Descricao());
            Console.WriteLine("Informe o valor do lado do quadrado em metros.");
            quadrado.Lado = Convert.ToInt32(Console.ReadLine());

            quadrado.CalcularArea();
            quadrado.CalcularPerimetro();
            Console.WriteLine($"A área do quadrado é : {quadrado.Area} m2 ");
            Console.WriteLine($"O perímetro do quadrado é : {quadrado.Perimetro} m ");
            Console.ReadKey();
        }

        public abstract class Forma
        {
            public double Area { get; set; }
            public string Cor { get; set; }
            public double Perimetro { get; set; }

            public abstract void CalcularArea();
            public abstract void CalcularPerimetro();

            public string Descricao() { return "Sou a classe abstrata Forma.";  }
        }

        public class Quadrado : Forma
        {
            public double Lado { get; set; }

            public override void CalcularArea()
            {
                Area = Lado * Lado;
            }

            public override void CalcularPerimetro()
            {
                Perimetro = 4 * Lado;
            }
        }
    }
}
