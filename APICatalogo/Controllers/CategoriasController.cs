using APICatalogo.Interface;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ILogger<CategoriasController> _logger; 
        private readonly IUnitOfWork _uof;
       

        public CategoriasController( ILogger<CategoriasController> logger, IUnitOfWork uof)
        {
            _logger = logger;
            _uof = uof;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            var categoria = _uof.CategoryRepository.GetAll();
            return Ok(categoria);
        }

        [HttpGet("{id}", Name ="ObterCategoria")]

        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _uof.CategoryRepository.Get(c => c.CategoriaId == id);
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
                

            var categoriaCriada = _uof.CategoryRepository.Create(categoria);
            _uof.Commit();
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


            _uof.CategoryRepository.Update(categoria);
            _uof.Commit();
            return Ok(categoria);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var categoria = _uof.CategoryRepository.Get(c => c.CategoriaId == id);
            if (categoria == null)
            {
                _logger.LogWarning($"Categoria com id={id} não encontrada.");
                return NotFound($"Categoria com id={id} não encontrada.");
            }

            var categoriaExcluida = _uof.CategoryRepository.Delete(categoria);
            _uof.Commit();
            return Ok(categoria);
        }

    }
}
