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
        private readonly IProdutoRepository _produtoRepository;
        private readonly IRepository<Produto> _repository;

        public ProdutosController(IRepository<Produto> repository, IProdutoRepository produtoRepository)
        {
            _repository = repository;
            _produtoRepository = produtoRepository;
        }
       
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetAll()
        {
            var produtos = _repository.GetAll().ToList();
            return Ok(produtos);
        }

        [HttpGet("produto/{id}")]
        public ActionResult<Produto> GetProdutos(int id)
        {
            var produto = _produtoRepository.GetProdutosPorCategoria (id);
            if (produto is null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpGet("{id}", Name = "ObterProduto")]

        public ActionResult<Produto> Get(int id)
        {
            var produto = _repository.Get(c => c.ProdutoId == id);
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
            var novoProduto = _repository.Create(produto);
           return new CreatedAtActionResult("ObterProduto", "Produtos", new { id = novoProduto.ProdutoId }, novoProduto);
        }

        [HttpPut("{id:int}")]
        public ActionResult Update(int id, Produto produto)
        {
            if (produto is null)
            {
                return BadRequest();
            }

            var produtoAtualizado = _repository.Update(produto);
            return Ok(produtoAtualizado);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var produto = _repository.Get(c => c.ProdutoId == id);
            if (produto is null)
            {
                return null;
            }

            var produtoDeletado = _repository.Delete(produto);
            return Ok (produtoDeletado);
        }

    }
}
