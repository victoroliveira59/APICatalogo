using APICatalogo.Context;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly APIWebContext _context;

        public ProdutosController(APIWebContext context)
        {
            _context = context;
        }
    }
}
