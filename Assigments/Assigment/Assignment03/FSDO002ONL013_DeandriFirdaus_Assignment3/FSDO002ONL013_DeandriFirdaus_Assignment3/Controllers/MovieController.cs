using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FSDO002ONL013_DeandriFirdaus_Assignment3.Models;
using MySql.Data.MySqlClient;

namespace FSDO002ONL013_DeandriFirdaus_Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {   
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            this._context = context;
        }

        [HttpGet(Name = "Get All")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetAllMovies();
        }

        [HttpGet("{id}", Name = "Get Where")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItem(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetMovie(id);
        }

        [HttpPost(Name = "Create")]
        public ActionResult<IEnumerable<MovieItem>> CreateMovieItem([FromBody] MovieItem movieItem)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.CreateMovie(movieItem);
        }

        [HttpPut("{id}",Name = "Update")]
        public ActionResult<IEnumerable<MovieItem>> UpdateMovieItem([FromBody] MovieItem movieItem)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.UpdateMovie(movieItem);
        }

        [HttpDelete("{id}",Name = "Delete")]
        public ActionResult<IEnumerable<MovieItem>> DeleteMovieItem([FromBody] MovieItem movieItem)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.DeleteMovie(movieItem);
        }
    }
}
