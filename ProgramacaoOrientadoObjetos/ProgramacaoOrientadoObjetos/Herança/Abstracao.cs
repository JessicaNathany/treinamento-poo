using System;
using System.Collections.Generic;
using System.Text;

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

        }

        public abstract class ContaCorrente
        {
            private readonly double _valor;
            private readonly string _saldo;

            public ContaCorrente(double valor, string saldo)
            {
                _valor = valor;
                _saldo = saldo;
            }

            public abstract void Sacar();
            public abstract void Desligar();
        }
    }
}
