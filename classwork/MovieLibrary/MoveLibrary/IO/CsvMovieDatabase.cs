namespace MovieLibrary.IO;

public class CsvMovieDatabase : MovieDatabase
{
    public CsvMovieDatabase ( string filename )
    {
        _filename = filename;
    }

    protected override Movie AddCore ( Movie movie )
    {
        IEnumerable<Movie> movies = LoadMovies();

        // Get highest ID
        var id = movies.Any() ? movies.Max(x => x.Id) : 0;
        movie.Id = ++id;

        // Save new movie
        File.AppendAllLines(_filename, new[] { WriteMovie(movie) });
        return movie;
    }
    protected override void DeleteCore ( int id )
    {
        var movies = LoadMovies().ToList();

        movies.RemoveAll(x => x.Id == id);

        SaveMovies(movies);

    
    }
    protected override Movie FindById ( int id )
    {
        return LoadMovies().FirstOrDefault(x => x.Id == id);
    }
    protected override Movie FindByTitle ( string title )
    {
        var movies = LoadMovies();
        return movies.FirstOrDefault(x => String.Equals( x.Title, title, StringComparison.OrdinalIgnoreCase) );
    }
    protected override IEnumerable<Movie> GetAllCore ()
    {
        return LoadMovies();
    }

    protected override Movie GetCore ( int id ) => FindById(id);

    protected override void UpdateCore ( int id, Movie movie )
    {
        var movies = LoadMovies().ToList();

        var existing = movies.FirstOrDefault(x => x.Id == id);
        if (existing == null)
            throw new InvalidOperationException("Movie not found");

        // Update
        existing.Title = movie.Title;
        existing.Description = movie.Description;
        existing.Genre = movie.Genre;
        existing.Rating = movie.Rating;
        existing.RunLength = movie.RunLength;
        existing.ReleaseYear = movie.ReleaseYear;
        existing.IsBlackAndWhite = movie.IsBlackAndWhite;

        SaveMovies(movies);
    }

    //Preferred
    //private IEnumerable<Movie> LoadMovies ()
    //{
    //    if (File.Exists(_filename))
    //    {
    //        //System.IO.File
    //        //string[] lines = File.ReadAllLines(_filename);
    //        //string text = File.ReadAllText(_filename);
    //        foreach (var line in File.ReadLines(_filename))
    //        {
    //            //TODO: Parse line
    //            var movie = ReadMovie(line);
    //            if ((movie?.Id ?? 0) > 0)
    //                yield return movie;
    //        };
    //    };
    //}

    private IEnumerable<Movie> LoadMovies ()
    {
        //if (File.Exists(_filename))
        //{
        //    Stream stream = File.OpenRead(_filename);
        //    StreamReader reader = null;
        //    //var reader = new StreamReader(stream);
        //try
        //{ 
        //    while (!reader.EndOfStream)
        //    {
        //        var line = reader.ReadLine();
        //        var movie = ReadMovie(line);
        //        if ((movie?.Id ?? 0) > 0)
        //            yield return movie;
        //    };
        //} finally
        //{
        //    // not exception safe
        //    reader?.Close();
        //    stream.Close();
        //};

        //};

        //Preferred approach - using statement /w IDisposable
        //using (var id = someresource) { S*}
        
        using Stream stream = File.OpenRead(_filename);
        using StreamReader reader = null;
            //var reader = new StreamReader(stream);
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var movie = ReadMovie(line);
            if ((movie?.Id ?? 0) > 0)
            yield return movie;
        };

    }

    private void SaveMovies ( IEnumerable<Movie> movies)
    {
        var contents = movies.Select(x => WriteMovie(x));
        File.WriteAllLines(_filename, contents);
    }

    //Id,"title", runlength, releaseyear,"genre","rating","isblackandwhite","description"

    private Movie ReadMovie ( string line )
    {
        if (String.IsNullOrEmpty(line))
            return null;

        string[] tokens = line.Split(',');
        if (tokens.Length != 8)
            return null;

        return new Movie() {
            Id = ToInt32(tokens[0]),
            Title = Dequote(tokens[1]),
            RunLength = ToInt32(tokens[2]),
            ReleaseYear = ToInt32(tokens[3]),
            Genre = Dequote(tokens[4]),
            Rating= new Rating(Dequote(tokens[5])),
            IsBlackAndWhite = ToInt32(tokens[6]) > 0,
            Description = Dequote(tokens[7])
        };

        
    }

    private string WriteMovie ( Movie movie )
    {
        var fields = new[] {
            movie.Id.ToString(),
            Enquote(movie.Title),
            movie.RunLength.ToString(),
            movie.ReleaseYear.ToString(),
            Enquote(movie.Genre),
            Enquote(movie.Rating.Name),
            movie.IsBlackAndWhite ? "1" : "0",
            Enquote(movie.Description)
        };

        return String.Join(',', fields);
    }

    private static int ToInt32 ( string value ) => Int32.TryParse(value, out var result) ? result : 0;

    private static string Enquote ( string value ) => "\"" + value + "\"";

    private static string Dequote ( string value ) => value.Trim('"');

    private readonly string _filename;
}