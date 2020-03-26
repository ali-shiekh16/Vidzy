using AutoMapper;
using System;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers.api
{
    public class MoviesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IHttpActionResult GetMovie(string query = null)
        {
            var moviesQuery = _context.Movies
                .Include(m => m.Genre);

            if (!string.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery
                    .Where(m => m.Name.Contains(query) && m.NumberAvailability > 0);
            
            
            var moviesDto = moviesQuery.ToList()
                .Select(Mapper.Map<Movie, MovieDto>);

            return Ok(moviesQuery);
        }

        [HttpGet]
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies
                .Include(c => c.Genre)
                .SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri($"{Request.RequestUri}/{movieDto.Id}"), movieDto);

        }

        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();
            Mapper.Map(movieDto, movie);

            _context.SaveChanges();

            movieDto.Id = id;

            return Created(new Uri(Request.RequestUri.ToString()), movieDto);
        }

        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            _context.Movies.Remove(movie);
            _context.SaveChanges();

            
            return Ok();
        }
    }
}
