// Movie data:
// Title, genre, description, mpaa rating
// Length, release year, budget
// IsBlackAndWhite
// Operations: Add, edit, view, delete

//TODO: Remove this
using MovieLibrary;

namespace MovieLibrary.ConsoleHost;

partial class Program
{
    static void Main ()
    {
        var app = new Program();
        app.Run ();
    }

    void Run ()
    { 
        Movie movie = new Movie();

        //Entry point
        var done = false;
        do
        {
            switch (DisplayMenu())
            {
                case MenuCommand.Add: movie = AddMovie(); break;
                case MenuCommand.Edit: EditMovie(); break;
                case MenuCommand.Delete:
                {
                    if (DeleteMovie(movie))
                        movie = new Movie();
                    break;
                }
                case MenuCommand.View: ViewMovie(movie); break;
                case MenuCommand.Quit:
                {
                    done = true;
                    break;
                }
                default: Console.WriteLine("Unknown option"); break;
            };

        } while (!done);
    }
    // Functions

    MenuCommand DisplayMenu ()
    {
        Console.WriteLine("-----------");
        Console.WriteLine("A)dd Movie");
        Console.WriteLine("E)dit Movie");
        Console.WriteLine("D)elete Movie");
        Console.WriteLine("V)iew Movie");
        Console.WriteLine("Q)uit");

        do
        {

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.A: return MenuCommand.Add;
                case ConsoleKey.E: return MenuCommand.Edit;
                case ConsoleKey.D: return MenuCommand.Delete;
                case ConsoleKey.V: return MenuCommand.View;
                case ConsoleKey.Q: return MenuCommand.Quit;
            };
        } while (true);
    }

    void EditMovie ()
    {
        Console.WriteLine("Not implemented yet");
    }

    bool DeleteMovie ( Movie movie )
    {
        if (String.IsNullOrEmpty(movie.Title))
            return false;

        if (!Confirm($"Are you sure you want to delete the movie '{movie.Title}' (Y/N)?"))
            return false;

        //TODO: Delete movie
        //title = "";

        return true;
    }

    Movie AddMovie ()
    {
        var movie = new Movie(10);
        movie.Title = "Something";
        movie.Description = "Something";

        do
        {
            movie.Title = ReadString("Enter a title: ", true);
            movie.Description = ReadString("Enter a description: ", false);

            movie.RunLength = ReadInt("Enter the run length (in mins): ", 0);
            movie.ReleaseYear = ReadInt("Enter the release year: ", Movie.MinimumReleaseYear);

            movie.Genre = ReadString("Enter a genre: ", false);
            movie.Rating = ReadRating("Enter a rating: ");
            //if (movie.Rating != null)
              //  movie.Rating.Name = "Whatever";

            movie.IsBlackAndWhite = ReadBoolean("Black and White (Y/N)?");
            //movie.NeedsIntermission = true;

            //Validate
            ValidatableObject validInstance = movie;

            var error = movie.Validate();
            if (String.IsNullOrEmpty(error))
                return movie;

            Console.WriteLine($"ERROR: {error}");
        } while (true);
    }

    void ViewMovie ( Movie movie )
    {
        if (String.IsNullOrEmpty(movie.Title))
        {
            Console.WriteLine("No movies available");
            return;
        }

        //movie.DownloadMetadata();


        Console.WriteLine();
        Console.WriteLine("".PadLeft(15, '-'));

        //movie.
        Console.WriteLine(movie.Title);

        // String formatting

        // Run Length: ## mins

        //Approach to use: String interpolation
        string message = $"Run Length: {movie.RunLength} mins";
        Console.WriteLine(message);
        if (movie.NeedsIntermission)
            Console.WriteLine("Includes intermission");

        // Released yyyy
        Console.WriteLine($"Released {movie.ReleaseYear}");

        Console.WriteLine(movie.Genre);

        // MPAA Rating:
        Console.WriteLine($"MPAA Rating: {movie.Rating}");

        //Black and White?
        //string format = "Color";
        //if (isBlackAndWhite)
        //    format = "Black and White";

        //V2
        //string format = isBlackAndWhite ? "Black and White" : "Color";
        //Console.WriteLine("Format: ".PadLeft(10) + format);

        //V3
        //Console.WriteLine("Format: " + (isBlackAndWhite ? "Black and White" : "Color"));

        Console.WriteLine(movie.Description);
    }

    bool Confirm ( string message )
    {
        return ReadBoolean(message);
    }

    /// <summary>Reads a boolean value.</summary>
    /// <param name="message">Message to show.</param>
    /// <returns>Returns true if value was true or false otherwise.</returns>
    bool ReadBoolean ( string message )
    {
        Console.WriteLine(message);

        //Handle errors

        while (true)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y: return true;

                case ConsoleKey.N: return false;
            };

        };
    }


    int ReadInt ( string message, int minimumValue )
    {
        Console.WriteLine(message);

        do
        {
            string value = Console.ReadLine();

            if (Int32.TryParse(value, out var result))
                if (result >= minimumValue)
                    return result;

            Console.WriteLine("Value must be at least " + minimumValue);
        } while (true);
    }


    string ReadString ( string message, bool isRequired )
    {
        Console.WriteLine(message);

        do
        {
            string value = Console.ReadLine().Trim();

            if (!isRequired || !String.IsNullOrEmpty(value))
                return value;

            Console.WriteLine("Value is required");
        } while (true);
    }

    Rating ReadRating ( string message )
    {
        Console.WriteLine(message);

        do
        {
            string value = Console.ReadLine();
            if (String.Equals(value, "PG", StringComparison.CurrentCultureIgnoreCase))
                return Rating.PG;
            else if (String.Equals(value, "G", StringComparison.CurrentCultureIgnoreCase))
                return Rating.G;
            else if (String.Equals(value, "PG-13", StringComparison.CurrentCultureIgnoreCase))
                return Rating.PG13;
            else if (String.Equals(value, "R", StringComparison.CurrentCultureIgnoreCase))
                return Rating.R;
            else if (String.IsNullOrEmpty(value))           //(value == "") // else if (value == String.Empty
                return null;

            Console.WriteLine("Invalid rating");
        } while (true);

        //string emptyValue;
        var areEqual = "" == String.Empty;  //true
        areEqual = "" == null; //false
    }
}