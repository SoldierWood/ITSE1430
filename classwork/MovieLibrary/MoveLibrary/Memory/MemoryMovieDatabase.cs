﻿using System;


namespace MovieLibrary.Memory;

/// <summary>Represents a database of movies.</summary>
public class MemoryMovieDatabase : MovieDatabase
{
    
    protected override Movie AddCore ( Movie movie )
    {
        //Validate: null, invalid movie
        //if (movie == null)
        //    return "Movie is null";
        //if (!new ObjectValidator().TryValidate(movie, out var error))
        //    return error.First().ErrorMessage;

        ////Title must be unique
        //var existing = FindByTitle(movie.Title);
        //if (existing != null)
        //    return "Movie title must be unique";

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
        movie.Id = _id++;
        _movies.Add(Clone(movie));
        
        return movie;
    }

    public string Update ( int id, Movie movie )
    {
        //Validate: null, invalid movie
        if (id <= 0)
            return "ID is invalid";

        if (movie == null)
            return "Movie is null";
        if (!ObjectValidator.TryValidate(movie, out var error))
            return error.First().ErrorMessage;

        //Title must be unique (and not self)
        var existing = FindByTitle(movie.Title);
        if (existing != null && existing.Id != id)
            return "Movie title must be unique";

        //Movie must exist
        existing = FindById(id);
        if (existing == null)
            return "Movie not found";

        //Update
        Copy(existing, movie);
        return "";
    }

    protected override void DeleteCore ( int id )
    {
        var movie = FindById(id);
        if (movie != null)
            _movies.Remove(movie);  //Reference equality applies
    }

    protected override Movie GetCore ( int id )
    {
        if (id <= 0)
            return null;

        var movie = FindById(id);

        if (movie == null)
            return null;

        return Clone(movie);
    }
    protected override IEnumerable<Movie> GetAllCore ()
    {
        //var count = _movies.Count;

        //////How many are not null
        ////var count = 0;
        ////for (var index = 0; index < _movies.Length; ++index)
        ////    if (_movies[index] != null)
        ////        ++count;        

        ////Clone array
        //var items = new Movie[_movies.Count];
        //var itemIndex = 0;
        //foreach (var movie in _movies)
        //    items[itemIndex++] = Clone(movie);

        ////for (var index = 0; index < _movies.Length; ++index)
        ////    if (_movies[index] != null)
        ////        items[itemIndex++] = Clone(_movies[index]);


        ///IIf return type is IEnumberable<T> then you may use iterator to implement

        foreach (var movie in _movies)
            yield return Clone(movie);

        //var items = new List<Movie>();
        //foreach (var movie in _movies)
        //    items.Add(Clone(movie));

        //return items;
    }

    private Movie Clone ( Movie movie )
    {
        var item = new Movie() { Id = movie.Id };
        Copy(item, movie);

        return item;
    }

    private void Copy ( Movie target, Movie source )
    {
        //Don't copy Id
        target.Title = source.Title;
        target.Description = source.Description;
        target.Rating = source.Rating;
        target.ReleaseYear = source.ReleaseYear;
        target.RunLength = source.RunLength;
        target.IsBlackAndWhite = source.IsBlackAndWhite;
        target.Genre = source.Genre;
    }

    protected override Movie FindById ( int id )
    {
        //for (var index = 0; index < _movies.Length; ++index)
        //    if (_movies[index]?.Id == id)
        //        return index;
        foreach (var movie in _movies)
            if (movie.Id == id)
                return movie;

        return null;
    }

    protected override Movie FindByTitle ( string title )
    {
        //for (var index = 0; index < _movies.Length; ++index)
        //    if (String.Equals(title, _movies[index]?.Title, StringComparison.OrdinalIgnoreCase))
        //        return _movies[index];
        foreach (var movie in _movies)
            if (String.Equals(title, movie.Title, StringComparison.OrdinalIgnoreCase))
                return movie;

        return null;
    }

    protected override void UpdateCore ( int id, Movie movie)
    {
        var existing = FindById(id);

        Copy(existing, movie);
    }

    //private readonly Movie[] _movies = new Movie[100];

    //List<T> generic type, resizable array of type T
    private readonly List<Movie> _movies = new List<Movie>();
    private int _id = 1;
}