using infnet_reavaliacao.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace infnet_reavaliacao.API.Controllers
{
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        // GET: AuthorsController
        public IActionResult Index()
        {
            return Ok();
        }

        // GET: AuthorsController/Details/5
        public IActionResult Details(int id)
        {
            return Ok();
        }

        // GET: AuthorsController/Create
        public IActionResult Create()
        {
            return Ok();
        }

        // POST: AuthorsController/Create
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

        // GET: AuthorsController/Edit/5
        public IActionResult Edit(int id)
        {
            return Ok();
        }

        // POST: AuthorsController/Edit/5
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

        // GET: AuthorsController/Delete/5
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        // POST: AuthorsController/Delete/5
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
