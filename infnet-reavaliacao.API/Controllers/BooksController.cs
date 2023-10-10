using infnet_reavaliacao.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace infnet_reavaliacao.API.Controllers
{
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: BooksController
        public IActionResult Index()
        {
            return Ok();
        }

        // GET: BooksController/Details/5
        public IActionResult Details(int id)
        {
            return Ok();
        }

        // GET: BooksController/Create
        public IActionResult Create()
        {
            return Ok();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                return BadRequest();
            }
            catch
            {
                return Ok();
            }
        }

        // GET: BooksController/Edit/5
        public IActionResult Edit(int id)
        {
            return Ok();
        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return BadRequest();
            }
            catch
            {
                return Ok();
            }
        }

        // GET: BooksController/Delete/5
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return BadRequest();
            }
            catch
            {
                return Ok();
            }
        }
    }
}
