using System.Linq.Expressions;
using APICatalogo.Context;
using APICatalogo.Interface;
using APICatalogo.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
         private readonly IUnitOfWork _uof;

        public ProdutosController(IUnitOfWork uof)
        {
            _uof = uof;
        }
       
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetAll()
        {
            var produtos = _uof.ProdutoRepository.GetAll().ToList();
            return Ok(produtos);
        }

        [HttpGet("produto/{id}")]
        public ActionResult<Produto> GetProdutos(int id)
        {
            var produto = _uof.ProdutoRepository.GetProdutosPorCategoria (id);
            if (produto is null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpGet("{id}", Name = "ObterProduto")]

        public ActionResult<Produto> Get(int id)
        {
            var produto = _uof.ProdutoRepository.Get(c => c.ProdutoId == id);
            if (produto is null)
            {
                return NotFound();
            }

            return Ok(produto);

        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto is null)
            {
                return BadRequest();
            }
            var novoProduto = _uof.ProdutoRepository.Create(produto);
            _uof.Commit();
           return new CreatedAtActionResult("ObterProduto", "Produtos", new { id = novoProduto.ProdutoId }, novoProduto);
        }

        [HttpPut("{id:int}")]
        public ActionResult Update(int id, Produto produto)
        {
            if (produto is null)
            {
                return BadRequest();
            }

            var produtoAtualizado = _uof.ProdutoRepository.Update(produto);
            _uof.Commit();
            return Ok(produtoAtualizado);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var produto = _uof.ProdutoRepository.Get(c => c.ProdutoId == id);
            if (produto is null)
            {
                return null;
            }

            var produtoDeletado = _uof.ProdutoRepository.Delete(produto);
            _uof.Commit();
            return Ok (produtoDeletado);
        }

    }
}
