using Microsoft.AspNetCore.Mvc.ModelBinding;
using ModelValidationAssignment.Interfaces;
using ModelValidationAssignment.Models;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationAssignment.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        List<Movie> movies = new List<Movie>();

        public void AddMovie(Movie movie)
        {
            movie.MoiveID = new Random().Next(1000, 9999);
            movies.Add(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovie(string name)
        {
            foreach (var movie in movies)
            {
                if (movie.MovieName == name)
                    return movie;
            }
            return null;
        }

        public List<Movie> GetMoviesByActor(string actor)
        {
            List<Movie> selectedMovied= new List<Movie>();
            foreach (var movie in movies)
            {
                if(movie.Actor==actor)
                    selectedMovied.Add(movie);
            }
            return selectedMovied;
        }

        public List<Movie> GetMoviesByDirector(string director)
        {
            List<Movie> selectedMovied = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.Director == director)
                    selectedMovied.Add(movie);
            }
            return selectedMovied;
        }

        public List<Movie> GetMoviesByYear(int year)
        {
            List<Movie> selectedMovied = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.YearofRelease == year)
                    selectedMovied.Add(movie);
            }
            return selectedMovied;
        }
    }
}
