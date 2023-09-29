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
    public class Movie : ValidatableObject
    {
        //ctors - initialize instances

        //Default contructor
        public Movie ()
        {
            //init anything that field inits won't work with
        }
        /// <summary>
        /// <summary> Initializes Movie class.</summary>
        /// </summary>
        /// <param name="id">Identifier of the movie.</param>
        public Movie ( int id ) : this(id, "")
        {
            //Id = id;
           
        }
        public Movie ( string Title)
        {
            Title = title;
        }

        //private void Initialize ( int id, string title)
        //{
        //    Id = id;
        //    Title = title;

            
        //}
        //Fields - data
        /// <summary> Title of movie. </summary>
        private string _title;

        //Properties - data with functionality

        /// <summary> Gets or sets the unique identifier of movie. </summary>
        public int Id { 
            //mixed accessibility - getter/setter has diffferent access than property
            get;
            /*set;*/
            private set;
        }
        public string Title
        {
            //string get()
            get {
                if (String.IsNullOrEmpty(_title))
                    return "";

                return _title;
            }

            //void set(string value)
            set {
                if (value != null)
                    value = value.Trim();
                _title = value;
            }
        }

        private string _description = "";

        public string Description
        {
            get {
                if (String.IsNullOrEmpty(_description))
                    return "";
                return _description; }
            
            set { _description = value; }
        }

        private string _genre = "";

        public string Genre
        {
            get {
                if (String.IsNullOrEmpty(_genre))
                    return "";
                return _genre; }
            set { _genre = value; }
        }

        private string _rating = "";

        public Rating Rating { get; set; }

        ////full property syntax
        //private int _length;

        //public int RunLength
        //{
        //    get { return _length; }
        //    set { _length = value; }
        //}

        //Auto property syntax
        public int RunLength { get; set; }

        private int _releaseYear = 1900;

        //public int ReleaseYear
        //{
        //    get { return _releaseYear; }
        //    set { _releaseYear = value; }
        //}

        public int ReleaseYear { get; set; } = MinimumReleaseYear;

        private bool _isBlackAndWhite;

        //public bool IsBlackAndWhite
        //{
        //    get { return _isBlackAndWhite; }
        //    set { _isBlackAndWhite = value; }
        //}

        public bool IsBlackAndWhite { get; set; }
        
        //Calculated property
        public bool NeedsIntermission
        {
            //Runlength > 150
            get { return RunLength >= 150; }
            //set { }
        }



        ///  <summary>Dowload metadata from Internet.</summary>summary></summary>
        /// <remarks>
        /// Searches
        /// </remarks>
        /// 

        /// <summary> Minimum release year.</summary>
        public const int MinimumReleaseYear = 1900;

        public readonly string DefaultRating = "PG";

        private void DownloadMetadata ()
        { }

        
        /// <summary>Validates movie instance.</summary>
        /// <returns> Error message if invalid or empty string otherwise.</returns>
        public string Validate ()
        {
            //Title is required
            if (String.IsNullOrEmpty(_title))
                return "Title is required";

            //Release Year >= 1900
            if (ReleaseYear < MinimumReleaseYear)
                return "Release Year must be >= 1900";

            //Length >= 0
            if (RunLength < 0)
                return "Length must be at least 0";

            //TODO: Rating is in list

            //If ReleaseYear < 1940 then IsBlackAndWhite must be true
            if (ReleaseYear < 1940 && !_isBlackAndWhite)
                return "Moves before 1940 must be black and white";

            //Valid
            return "";
        }
    }
}