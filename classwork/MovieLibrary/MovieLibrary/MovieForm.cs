﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLibrary.Business;

namespace MovieLibrary.Winforms
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }

        public MovieForm( Movie movie) : this(movie != null ? "Edit" : "Add", movie)
        {
            //InitializeComponent();
            //Movie = movie;

            //Text = movie != null ? "Edit" : "Add";
        }

        public MovieForm ( string title, Movie movie ) : this()
        {
            Text = title;
            Movie = movie;
        }
        public Movie Movie
        {
            get { return _movie; }
            set { _movie = value; }
        }
        private Movie _movie;

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnOK ( object sender, EventArgs e )
        {
            //TODO: Validation and error reporting
            var movie = GetMovie();
            if (!movie.Validate(out var error))
            {
                DisplayError(error);
                return;
            }

            Movie = movie;
            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            var genres = Genres.GetAll();
            ddlGenres.Items.AddRange(genres);

            if (Movie != null)
            {
                txtTitle.Text = Movie.Title;
                txtDescription.Text = Movie.Description;
                txtReleaseYear.Text = Movie.ReleaseYear.ToString();
                txtRunLength.Text = Movie.RunLength.ToString();
                chkIsClassic.Checked = Movie.IsClassic;

                if (Movie.Genre != null)
                    ddlGenres.SelectedText = Movie.Genre.Description;
            };
        }

        private Movie GetMovie ()
        {
            var movie = new Movie();

            //Null conditional, not required below
            //No string property will ever return null
            movie.Title = txtTitle.Text?.Trim();
            movie.RunLength = GetAsInt32(txtRunLength);
            movie.ReleaseYear = GetAsInt32(txtReleaseYear, 1900);
            movie.Description = txtDescription.Text.Trim();
            movie.IsClassic = chkIsClassic.Checked;


            //movie.Genre = (Genre)ddlGenres.SelectedItem; //C-style, crashes if wrong

            //Preferred - as operator
            //var genre = ddlGenres.SelectedItem as Genre; 
            //if (genre != null)
            //    movie.Genre = genre;

            //Pattern match
            //movie.Genre = ddlGenres.SelectedItem;

            if (ddlGenres.SelectedItem is Genre genre)
                movie.Genre = genre;

            return movie;
        }

        //private bool ValidateMovie ( Movie movie )
        //{
        //    //Title is required
        //    //if (txtTitle.Text?.Trim() == "")
        //    if (String.IsNullOrEmpty(movie.Title))
        //    {
        //        DisplayError("Title is required.");
        //        return false;
        //    };

        //    //Run length >= 0
        //    if (movie.RunLength < 0)
        //    {
        //        DisplayError("Run length must be >= 0.");
        //        return false;
        //    };

        //    //Release year >= 1900
        //    if (movie.ReleaseYear < 1900)
        //    {
        //        DisplayError("Release year must be >= 1900.");
        //        return false;
        //    };

        //    return true;
        //}

        /// <summary>Displays an error message.</summary>
        /// <param name="message">Error to display.</param>
        private void DisplayError ( string message )
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int GetAsInt32 ( Control control )
        {
            return GetAsInt32(control, 0);
        }

        private int GetAsInt32 ( Control control, int emptyValue )
        {
            if (String.IsNullOrEmpty(control.Text))
                return emptyValue;

            if (Int32.TryParse(control.Text, out var result))
                return result;

            return -1;
        }

        
    }
}