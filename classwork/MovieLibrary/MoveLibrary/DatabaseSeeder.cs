namespace MovieLibrary

{
    public static class DatabaseSeeder
    {
        public static void Seed ( this IMovieDatabase database )    // extension method
        {
            var movies = new[] {
                    new Movie() {
                        Title = "Jaws",
                        ReleaseYear = 1977,
                        Rating = Rating.PG,
                        RunLength = 120,
                    },
                    new Movie() {
                        Title = "Dune",
                        ReleaseYear = 1983,
                        Rating = Rating.PG13,
                        RunLength = 210,
                    },
                    new Movie() {
                        Title = "Star Wars",
                        ReleaseYear = 1977,
                        Rating = Rating.PG,
                        RunLength = 150,
                    },
                };

            //Enumeration - use foreach
            // foreach-statement ::= foreach (T id in array) S;
            // 1. variant is readonly
            // 2. array must be immutable while enumerating
            //for (int index = 0; index < movies.Length; ++index)
            //   Add(movies[index]);
            foreach (var movie in movies)
                database.Add(movie);
        }
    }
}


