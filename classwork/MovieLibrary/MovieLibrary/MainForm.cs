using System;
using System.Windows.Forms;

using MovieLibrary.Business;

namespace MovieLibrary
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();

<<<<<<< HEAD
            //MovieLibrary.Business.Movie;
            var movie = new Movie();

=======
            #region Playing with objects

            //Full name
            //MovieLibrary.Business.Movie;
            var movie = new Movie();
                        
>>>>>>> 963da44b8d88cae5ba300f89ac9374a94f14cd9c
            movie.title = "Jaws";
            movie.description = movie.title;

            movie = new Movie();
<<<<<<< HEAD
            //DisplayMovie(movie);
            //DisplayMovie(null);
           // DisplayError("Some error");
            DisplayConfirmation("Are you sure?", "Start");
        }
        private bool DisplayConfirmation ( string message, string title )
        {
            //if (MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) ;
            //return true;

            var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            return result == DialogResult.OK;

        }
=======

            //DisplayMovie(movie);
            //DisplayMovie(null);
            DisplayConfirmation("Are you sure?", "Start");
            #endregion
        }

        private bool DisplayConfirmation ( string message, string title )
        {
            //Display a confirmation dialog
            var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //Return true if user selected OK
            return result == DialogResult.OK;
        }

>>>>>>> 963da44b8d88cae5ba300f89ac9374a94f14cd9c
        /// <summary>Displays an error message.</summary>
        /// <param name="message">Error to display.</param>
        private void DisplayError ( string message )
        {
<<<<<<< HEAD
            //var that = this;
            MessageBox.Show(message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //var newTitle = Text;
            //var newTitle = Text;

        }
        void DisplayMovie( Movie movie )
        {
            if (movie == null)
                return; // Handle null values, or object breaks.
            var title = movie.title;
            movie.description = "Test"; 

            //movie = new Movie(); function cannot change what original pointed to. Always point by value.
=======
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
            
            var title = movie.title;
            movie.description = "Test";

            movie = new Movie();
>>>>>>> 963da44b8d88cae5ba300f89ac9374a94f14cd9c
        }
        #endregion
    }
}
