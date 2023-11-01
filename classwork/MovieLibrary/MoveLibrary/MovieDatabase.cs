﻿using System;

namespace MovieLibrary;

/// <summary>Represents a database of movies.</summary>
public abstract class MovieDatabase : IMovieDatabase
{
    //public MemoryMovieDatabase ()
    //{
    //    //Object initializer - replaces need for creating an object (expression) and then assigning values to properties (statements)
    //    // object-initializer ::= new T() { property-assignment+ }
    //    // property-assignment ::= id = Et,
    //    //var movie = new Movie();
    //    //movie.Id = _id++;
    //    //movie.Title = "Jaws";
    //    //movie.ReleaseYear = 1977;
    //    //movie.Rating = Rating.PG;
    //    //movie.RunLength = 120;
    //    //_movies[0] = movie;
    //    //_movies[0] = new Movie() {
    //    //    Id = _id++,
    //    //    Title = "Jaws",
    //    //    ReleaseYear = 1977,
    //    //    Rating = Rating.PG,
    //    //    RunLength = 120,
    //    //};

    //    //Collection initializer syntax
    //    // new T[] { E, E, E }
    //    //Set up movies
    //    var movies = new[] {
    //                new Movie() {
    //                    Title = "Jaws",
    //                    ReleaseYear = 1977,
    //                    Rating = Rating.PG,
    //                    RunLength = 120,
    //                },
    //                new Movie() {
    //                    Title = "Dune",
    //                    ReleaseYear = 1983,
    //                    Rating = Rating.PG13,
    //                    RunLength = 210,
    //                },
    //                new Movie() {
    //                    Title = "Star Wars",
    //                    ReleaseYear = 1977,
    //                    Rating = Rating.PG,
    //                    RunLength = 150,
    //                },
    //            };

    //    //Enumeration - use foreach
    //    // foreach-statement ::= foreach (T id in array) S;
    //    // 1. variant is readonly
    //    // 2. array must be immutable while enumerating
    //    //for (int index = 0; index < movies.Length; ++index)
    //    //   Add(movies[index]);
    //    foreach (var movie in movies)
    //        Add(movie);
    //}

    public virtual string Add ( Movie movie )
    {
        //Validate: null, invalid movie
        if (movie == null)
            return "Movie is null";
        if (!new ObjectValidator().TryValidate(movie, out var error))
            return error.First().ErrorMessage;

        //Title must be unique
        var existing = FindByTitle(movie.Title);
        if (existing != null)
            return "Movie title must be unique";

        //HACK: This is a hack for now
        var newMovie = AddCore(movie);
        movie.Id = newMovie.Id;
        return "";
    }
    protected abstract Movie GetCore ( int id );

    protected abstract Movie AddCore ( Movie movie );


    public string Update ( int id, Movie movie )
    {
        //Validate: null, invalid movie
        if (id <= 0)
            return "ID is invalid";

        if (movie == null)
            return "Movie is null";
        if (!new ObjectValidator().TryValidate(movie, out var error))
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

    protected abstract void UpdateCore ( int id, Movie movie );

    public virtual void Delete ( int id )
    {
        //TODO:Id > 0

        DeleteCore(id);
    }

    protected abstract void DeleteCore ( int id );

    public virtual IEnumerable<Movie> GetAll ()
    {
        return GetAllCore();

    }


    protected abstract Movie FindById ( int id );

    protected abstract Movie FindByTitle ( string title );
    
    //private readonly Movie[] _movies = new Movie[100];

    //List<T> generic type, resizable array of type T
    //private readonly List<Movie> _movies = new List<Movie>();
    //private int _id = 1;
}