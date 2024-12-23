using APICatalogo.Interface;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly IRepository<Categoria> _repository;
        private readonly ILogger<CategoriasController> _logger;
       

        public CategoriasController(IRepository<Categoria> repository, ILogger<CategoriasController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            var categoria = _repository.GetAll().ToList();
            return Ok(categoria);
        }

        [HttpGet("{id}", Name ="ObterCategoria")]

        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _repository.Get(c => c.CategoriaId == id);
            if (categoria is null)
            {
                _logger.LogWarning($"A categoria não foi encontrada pelo {id}");
            }

            return Ok(categoria);
        }

        [HttpPost]
        public ActionResult Post(Categoria? categoria)
        {
            if (categoria is null)
            {
                _logger.LogWarning($"Dados inválidoas.");
                return BadRequest();
            }
                

            var categoriaCriada = _repository.Create(categoria);
            return CreatedAtRoute("ObterCategoria", new { id = categoriaCriada!.CategoriaId }, categoriaCriada);


        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Categoria categoria)
        {
            if (id != categoria.CategoriaId)
            {
                _logger.LogWarning($"Dados Invalidos.");
                return BadRequest("Dados Invalidos.");
            }


            _repository.Update(categoria);
            return Ok(categoria);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var categoria = _repository.Get(c => c.CategoriaId == id);
            if (categoria == null)
            {
                _logger.LogWarning($"Categoria com id={id} não encontrada.");
                return NotFound($"Categoria com id={id} não encontrada.");
            }

            var categoriaExcluida = _repository.Delete(categoria);
            return Ok(categoria);
        }

    }
}
