/*
 * ITSE 1430
 * Fall 2023
 * 
 */

namespace MovieLibrary
{
    /// <summary> Represents a movie. </summary>
    /// <remarks>
    /// Paragraphs of descriptions.
    /// </remarks>
    public class Movie
    {
        //Fields - data
        /// <summary> Title of movie. </summary>
        public string title = "";
        public string description = "";
        public string genre = "";
        public string rating = "";

        public int length;
        public int releaseYear = 1900;
        public bool isBlackAndWhite;

        ///  <summary>Dowload metadata from Internet.</summary>summary></summary>
        /// <remarks>
        /// Searches
        /// </remarks>
        private void DownloadMetadata ()
        { }

        
        /// <summary>Validates movie instance.</summary>
        /// <returns> Error message if invalid or empty string otherwise.</returns>
        public string Validate ()
        {
            //Title is required
            if (String.IsNullOrEmpty(title))
                return "Title is required";

            //Release Year >= 1900
            if (releaseYear < 1900)
                return "Release Year must be >= 1900";

            //Length >= 0
            if (length < 0)
                return "Length must be at least 0";

            //TODO: Rating is in list

            //If ReleaseYear < 1940 then IsBlackAndWhite must be true
            if (releaseYear < 1940 && !isBlackAndWhite)
                return "Moves before 1940 must be black and white";

            //Valid
            return "";
        }
    }
}