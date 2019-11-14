using System;
using Demo.Pubs.Core.Exceptions;
using Demo.Pubs.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Demo.Pubs.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Demo.Pubs.API.Controllers
{
    //[ApiVersion("1")]
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            return Ok();
        }
        
        /// <summary>
        /// Retrieving a Book using its BookId
        /// </summary>
        /// <remarks>
        /// Retrieves a Book using its BookId
        /// </remarks>
        /// <param name="id">The Id of the Book item to be retrieved</param>
        /// <returns>Returns the full Book document </returns>
        /// <returns>Returns 200 OK success </returns>
        /// <returns>Returns 404 Not Found error</returns>
        /// <returns>Returns 500 Internal Server Error </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBook(string id)
        {
            try
            {
                var book = await _repository.GetByIdAsync(id);
                return Ok(book);
            }
            catch (EntityNotFoundException)
            {
                return NotFound(id);
            }
        }


    }
}