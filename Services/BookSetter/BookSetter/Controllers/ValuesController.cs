using InfrastractureBook;
using Microsoft.AspNetCore.Mvc;
using SetBookDTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookSetter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetBookController : ControllerBase
    {
        private readonly Interface1 tera;
        public SetBookController(Interface1 ter)
        {
            tera = ter;

        }
        // GET api/<ValuesController>/5
        [HttpGet("{name}")]
        public SetBookDTOa Get(string name)
        {
            return tera.SetBooka(name);
        }
    }
}
