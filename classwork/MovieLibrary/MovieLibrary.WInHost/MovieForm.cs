﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.WInHost
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }
        /// <summary> Gets or sets the new movie. </summary>
        public Movie Movie { get; set; }


        private void OnSave ( object sender, EventArgs e )
        {
            var movie = new Movie();

            //Populate from the UI
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;   
            movie.Genre = _txtGenre.Text;

            movie.Rating = new Rating(_cbRating.Text);
            movie.ReleaseYear = GetInt32(_txtReleaseYear, 0);
            movie.RunLength = GetInt32(_txtRunLength, -1);

            movie.IsBlackAndWhite = _chkIsBlackAndWhite.Checked;

            if (!movie.TryValidate(out var error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            };

            Movie = movie;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private int GetInt32 ( Control control, int defaultValue )
        {
            if (Int32.TryParse(control.Text, out var value))
                return value;

            return defaultValue;
        }
    }
}
