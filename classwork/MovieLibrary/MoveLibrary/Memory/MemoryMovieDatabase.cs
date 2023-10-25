
using MovieLibrary;

namespace MoveLibrary.Memory;

/// <summary>Represents a database of movies.</summary>
public class MemoryMovieDatabase
{
    public MemoryMovieDatabase ()
    {
        //Object initializer
        //var movie = new Movie();
        //movie.Id = _id++;
        //movie.Title = "Jaws";
        //movie.ReleaseYear = 1977;
        //movie.Rating = Rating.PG;
        //movie.RunLength = 120;
        //_movies[0] = movie;
        _movies[0] = new Movie() {
            Id = _id++,
            Title = "Jaws",
            ReleaseYear = 1977,
            Rating = Rating.PG,
            RunLength = 120,
        };

        //TODO: Fix this
        var movie = new Movie();
        movie.Id = _id++;
        movie.Title = "Dune";
        movie.ReleaseYear = 1983;
        movie.Rating = Rating.PG13;
        movie.RunLength = 210;
        _movies[1] = movie;

        movie = new Movie();
        movie.Id = _id++;
        movie.Title = "Star Wars";
        movie.ReleaseYear = 1977;
        movie.Rating = Rating.PG;
        movie.RunLength = 150;
        _movies[2] = movie;
    }

    public string Add ( Movie movie )
    {
        //Validate: null, invalid movie
        if (movie == null)
            return "Movie is null";
        if (!movie.TryValidate(out var error))
            return error;

        //Title must be unique
        var existing = FindByTitle(movie.Title);
        if (existing != null)
            return "Movie title must be unique";

        ////Find an empty slot
        //for (var index = 0; index < _movies.Length; ++index)
        //{
        //    if (_movies[index] == null)
        //    {
        //        movie.Id = _id++;
        //        _movies[index] = Clone(movie);
        //        return "";
        //    };
        //};

        _movies.Add(Clone(movie));

        return "";
    }

    public string Update ( int id, Movie movie )
    {
        //Validate: null, invalid movie
        if (id <= 0)
            return "ID is invalid";

        if (movie == null)
            return "Movie is null";
        
        if (!movie.TryValidate(out var error))
            return error;

        //Title must be unique and not self
        var existing = FindByTitle(movie.Title);
        if (existing != null && existing.Id != id)
            return "Movie title must be unique";

        existing = FindById(id);
        if (existing == null)
            return "Movie not found";

        //Update
        Copy(existing, movie);

        return "";

    }

    public void Delete ( int id )
    {
        //TODO:Id > 0

        //var index = FindById(id);
        //if (index >= 0)
        //    _movies[index] = null;

        var movie = FindById(id);
        if (movie != null)
            _movies.Remove(movie);  //reference equality applies
    }

    public Movie[] GetAll ()
    {
        var count = _movies.Count;
        
        ////How many are not null
        //var count = 0;
        //for (var index = 0; index < _movies.Length; ++index)
        //    if (_movies[index] != null)
        //        ++count;

        //Clone array
        var items = new Movie[_movies.Count];
        var itemIndex = 0;
        foreach (var movie in _movies)
            items[itemIndex++] = Clone(movie);

        //for (var index = 0; index < _movies.Length; ++index)
        //    if (_movies[index] != null)
        //        items[itemIndex++] = Clone(_movies[index]);

        return items;
    }

    private Movie Clone ( Movie movie )
    {
        var item = new Movie();
        item.Id = movie.Id;
        Copy(item, movie);

        return item;
    }

    private void Copy ( Movie target, Movie source )
    {
        //don't copy ID
        target.Title = source.Title;
        target.Description = source.Description;
        target.Rating = source.Rating;
        target.ReleaseYear = source.ReleaseYear;
        target.RunLength = source.RunLength;
        target.IsBlackAndWhite = source.IsBlackAndWhite;
        target.Genre = source.Genre;

    }

    private Movie FindById ( int id )
    {
        //for (var index = 0; index < _movies.Length; ++index)
        //    if (_movies[index]?.Id == id)
        //        return index;

        foreach (var movie in _movies)
            if (movie.Id == id)
                return movie;

        return null;
    }

    private Movie FindByTitle ( string title )
    {
        foreach (var movie in _movies)
            if (String.Equals(title, movie.Title, StringComparison.OrdinalIgnoreCase))
                return movie;


        //for (var index = 0; index < _movies.Length; ++index)
        //    if (String.Equals(title, _movies[index]?.Title, StringComparison.OrdinalIgnoreCase))
        //        return _movies[index];

        return null;
    }


    //List<T> generic type, resizable array of type T
    private readonly List<Movie> _movies = new List<Movie>();
    private int _id = 1;
}
