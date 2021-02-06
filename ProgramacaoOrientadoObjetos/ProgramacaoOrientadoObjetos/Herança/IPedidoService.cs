using ProgramacaoOrientadoObjetos.Classes_e_Ojetos;
using ProgramacaoOrientadoObjetos.Herança;

public interface IPedidoService : IBaseService<Pedido>
{
    void CancelarPedido(Pedido pedido);
    void FecharPedido(int idPedido);
    void AlterarStatusPedido(int idPedido, int idStatus);
}