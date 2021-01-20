using ProgramacaoOrientadoObjetos.Classes_e_Ojetos;

namespace ProgramacaoOrientadoObjetos.Herança
{
    public interface IProdutoService : IBaseService<Produto>
    {
        bool ExisteProdutoNoEstoque(int id);
        bool ObtemProdutoPorFornecedor(int idProdutoFornecedor);
        void AlteraValorProdutoPorFornecedor(Produto produto);
    }
}
