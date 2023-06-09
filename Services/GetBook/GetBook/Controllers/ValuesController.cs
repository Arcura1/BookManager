using BookDTO;
using Infra;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GetBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly InterBook tera;
        public BookController(InterBook ter)
        {
            tera = ter;

        }
        // GET: api/<ValuesController>
        [HttpGet("{email}")]
        public BookDTOa Getaa(string email)
        {
            return tera.GetAllBook(email);
        }

    }
}
