using Infrastucture;
using LoginDTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Inter tera;
        public ValuesController(Inter ter) { 
        tera= ter;
        
        }
        // GET: api/<ValuesController>
        [HttpGet("{email}/{Pass}")]
        public LoginDTOa Getaa(string email,string Pass)
        {
            return tera.Geta(email,Pass);
        }
    }
}
