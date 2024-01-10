using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelValidationAssignment.Models;
using ModelValidationAssignment.Repositories;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ModelValidationAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movie_Controller : ControllerBase
    {
        MovieRepository movieRepository;

        public Movie_Controller(MovieRepository movieRepository) 
        {
            this.movieRepository = movieRepository;

        }



        [HttpPost("Register")]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieRepository.AddMovie(movie);
                return StatusCode(200, "Movie registered");
            }
            else
                return BadRequest();            
        }

        [HttpGet("All movies")]
        public IActionResult GetMovies()
        {
            return StatusCode(200, movieRepository.GetAllMovies());
        }

        [HttpGet("Get Movie by name")]
        public IActionResult GetMovieByName(string name) 
        { 
            return StatusCode(200, new JsonResult(movieRepository.GetMovie(name)));
        }

        [HttpGet("Get Movie by Actor")]
        public IActionResult GetMovieByActor(string actor)
        {
            return StatusCode(200, new JsonResult(movieRepository.GetMoviesByActor(actor)));
        }

        [HttpGet("Get Movie by director")]
        public IActionResult GetMovieByDirector(string director)
        {
            return StatusCode(200, new JsonResult(movieRepository.GetMoviesByDirector(director)));
        }

        [HttpGet("Get Movie by year")]
        public IActionResult GetMovieByYear(int year)
        {
            return StatusCode(200, new JsonResult(movieRepository.GetMoviesByYear(year)));
        }




    }
}
