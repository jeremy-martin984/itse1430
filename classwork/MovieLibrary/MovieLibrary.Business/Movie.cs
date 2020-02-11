using System;

namespace MovieLibrary.Business
{
<<<<<<< HEAD
    /// <summary>
    /// Represents a movie.
    /// </summary>
    public class Movie
    {

        public string title;
        /// <summary>
        /// Run length in minutes.
        /// </summary>
        /// <remarks>Lots and lots of info</remarks>
        // Self documentation for code
        public int runLength;
        public string description;

        public int releaseYear = 1900;

=======
    /// <summary>Represents a movie.</summary>
    /// <remarks>
    /// Lots of info.
    /// </remarks>
    public class Movie
    {
        /// <summary>Gets or sets the title.</summary>
        public string title;

        /// <summary>Gets or sets the run length in minutes.</summary>
        public int runLength;

        /// <summary>Gets or sets the description.</summary>
        public string description;

        /// <summary>Gets or sets the release year.</summary>
        /// <value>Default is 1900.</value>
        public int releaseYear = 1900;

        /// <summary>Determines if this is a classic movie.</summary>
>>>>>>> 963da44b8d88cae5ba300f89ac9374a94f14cd9c
        public bool isClassic;
    }
}
