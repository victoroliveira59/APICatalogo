using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using APICatalogo.Interface;
using APICatalogo.Models;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PrateleirasController : ControllerBase
    {
        private readonly IPrateleira _prateleira;
        private readonly IRepository<Prateleira> _repository;

        public PrateleirasController(IRepository<Prateleira> repository, IPrateleira prateleira)
        {
            _repository = repository;
            _prateleira = prateleira;
        }
    }
}