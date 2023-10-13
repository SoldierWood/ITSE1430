namespace MovieLibrary.WInHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
       

       
       

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }
        private void OnAddMovie ( object sender, EventArgs e )
        {
            var dlg = new MovieForm();

            //dlg.Show();   // modeless

            if (dlg.ShowDialog() != DialogResult.OK) // modal
                return;

            _movie = dlg.Movie;
            RefreshMovies();

        }

        private void OnEditMovie ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            var dlg = new MovieForm();
            dlg.Movie = movie;

            //dlg.Show();   // modeless

            if (dlg.ShowDialog() != DialogResult.OK) // modal
                return;

            _movie = dlg.Movie;
            RefreshMovies();
        }

        private void OnDeleteMovie ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;
            if (!Confirm("Delete", $"Are you sure you want to delete '{movie.Title}'?"))
                return;

            //TODO: Delete movie
            _movie = null;
            RefreshMovies();
        }
        
        private void OnHelpAbout (object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }

        private bool Confirm (string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private Movie GetSelectedMovie ()
        {
            return _movie;
        }

        private void RefreshMovies()
        {
            _lstMovies.DataSource = null;

            if (_movie != null)
                _lstMovies.DataSource = new[] { _movie };
        }

        private Movie _movie = new Movie() { Title = "Jaws"};

        
    }
}