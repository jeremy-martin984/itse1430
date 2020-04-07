using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Business
{
    public static class SeedDatabase
    {
        public static IMovieDatabase SeedIfEmpty ( this IMovieDatabase database )
        {
            if (database.GetAll().Any())
            {
                database.Add(new Movie() { Title = "Jaws", RunLength = 95, ReleaseYear = 1977, Description = "A movie about evil fisherman hunting an innocent shark" });
                database.Add(new Movie() { Title = "Jaws 2", RunLength = 95, ReleaseYear = 1977, Description = "A movie about evil fisherman hunting an innocent shark" });
                database.Add(new Movie() { Title = "Dune", RunLength = 95, ReleaseYear = 1977, Description = "A movie about evil fisherman hunting an innocent shark" });
                database.Add(new Movie() { Title = "Star wars", RunLength = 95, ReleaseYear = 1977, Description = "A movie about evil fisherman hunting an innocent shark" });
            };
            return database;
        }
    }
}
