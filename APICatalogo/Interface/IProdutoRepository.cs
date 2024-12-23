using APICatalogo.Models;

namespace APICatalogo.Interface;

public interface IProdutoRepository : IRepository<Produto>
{
         IEnumerable<Produto> GetProdutosPorCategoria(int id);
}