using APICatalogo.Context;
using APICatalogo.Interface;
using APICatalogo.Models;
using System.Linq;

namespace APICatalogo.Repository;

public class ProdutoRepository : Repository<Produto>, IProdutoRepository
{
       public ProdutoRepository(APIWebContext context) : base(context)
       {
       }

       public IEnumerable<Produto> GetProdutosPorCategoria(int id)
       {
           return GetAll().Where( c => c.CategoriaId == id);
       }
}