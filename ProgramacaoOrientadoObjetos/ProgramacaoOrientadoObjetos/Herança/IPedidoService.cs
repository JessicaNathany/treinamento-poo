using ProgramacaoOrientadoObjetos.Classes_e_Ojetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadoObjetos.Herança
{
    public interface IPedidoService : IBaseService<Pedido>
    {
        void FecharPedido(int id);
        Pedido DetalhesPedido(int id);
        void Salvar(Pedido pedido);

    }
}
