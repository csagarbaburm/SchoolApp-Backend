using ModelValidationAssignment.Models;
namespace ModelValidationAssignment.Interfaces
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);
        Movie GetMovie(string name);
        List<Movie> GetAllMovies();
        List<Movie> GetMoviesByActor(string actor);
        List<Movie> GetMoviesByDirector(string director);
        List<Movie> GetMoviesByYear(int year);
    }
}
