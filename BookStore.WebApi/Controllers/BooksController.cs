using BookStore.Core;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices _bookServices;

        public BooksController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_bookServices.GetList());
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookServices.Add(book);
            return Ok(book);
        }

        [HttpGet("{id}", Name = "GetBook")]
        public IActionResult GetBook(string id)
        {
            var book = _bookServices.Get(id);
            return Ok(book);
        }
    }
}
