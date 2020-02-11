using System;
using System.Windows.Forms;

using MovieLibrary.Business;
using MovieLibrary.Winforms;

namespace MovieLibrary
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();

            #region Playing with objects

            //Full name
            //MovieLibrary.Business.Movie;
            var movie = new Movie();
                        
            movie.Title = "Jaws";
            movie.description = movie.Title;

            movie = new Movie();

            //DisplayMovie(movie);
            //DisplayMovie(null);
            //DisplayConfirmation("Are you sure?", "Start");
            #endregion
        }

        private bool DisplayConfirmation ( string message, string title )
        {
            //Display a confirmation dialog
            var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //Return true if user selected OK
            return result == DialogResult.OK;
        }

        /// <summary>Displays an error message.</summary>
        /// <param name="message">Error to display.</param>
        private void DisplayError ( string message )
        {
            #region Playing with this

            //this represents the current instance
            //var that = this;

            //var Text = "";

            //These are equal
            //var newTitle = this.Text;
            //var newTitle = Text;
            #endregion

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region Playing with methods

        void DisplayMovie ( Movie movie )
        {
            if (movie == null)
                return;
            
            var title = movie.Title;
            movie.description = "Test";

            movie = new Movie();
        }
        #endregion

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            //modal window = showDialog()
            //modeless = Show()
            MovieForm child = new MovieForm();
            child.ShowDialog(this);
            //child.Show();
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

        }

        private void ExitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Close();
        }
    }
}
