using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Business.SqlServer
{
    public class SqlMovieDatabase : MovieDatabase
    {

        public SqlMovieDatabase ( string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override Movie AddCore ( Movie movie )
        {
            using (var conn = OpenConnection())
            {
                var cmd = new SqlCommand("AddMovie", conn);
                //var cmd2 = conn.CreateCommand();
                //cmd.CommandText = "AddMovie";
                //TODO logic
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add parameters
                //1 long way
                var pName = new SqlParameter("@name", movie.Title);
                cmd.Parameters.Add(pName);

                //2 shorter way
                var pGenre = cmd.Parameters.Add("@genre", System.Data.SqlDbType.NVarChar);
                if (movie.Genre != null)
                    pGenre.Value = movie.Genre.Description;

                //3. Short short version
                cmd.Parameters.AddWithValue("@description", movie.Description);
                cmd.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
                cmd.Parameters.AddWithValue("@runLength", movie.RunLength);
                cmd.Parameters.AddWithValue("@IsClassic", movie.IsClassic);

                //Executes the cmd and returns back the first value of the first row, if any
                var result = cmd.ExecuteScalar();

                var id = Convert.ToInt32(result);
                movie.Id = id;



                return movie;
            };
        }

        protected override void DeleteCore ( int id )
        {
            using (var conn = OpenConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DeleteMovie";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                //Ignore return value
                cmd.ExecuteNonQuery();
            };
        }

        protected override Movie FindById ( int id )
        {
            var items = GetAllCore();

            return items.FirstOrDefault(i => i.Id == id);
        }

        protected override Movie FindByTitle ( string title )
        {
            var items = GetAllCore();

            return items.FirstOrDefault(m => String.Compare(m.Title, title, true) == 0);
        }

        protected override IEnumerable<Movie> GetAllCore ()
        {
            var items = new List<Movie>();

            var ds = new DataSet();

            using (var conn = OpenConnection())
            {
                //TODO logic
                var cmd = conn.CreateCommand();
                cmd.CommandText = "GetMovies";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //buffered approach - dataset


                //intermediary
                var da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(ds);

            };

            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if (table != null)
            {
                foreach (var row in table.Rows.OfType<DataRow>())
                {
                    var movie = new Movie()
                    {
                        Id = Convert.ToInt32(row[0]),
                        Title = row["Name"]?.ToString(),
                        Description = row.Field<string>(2),
                        //Genre = row.Field<string>("Genre"),
                        ReleaseYear = row.Field<int>("ReleaseYear"),
                        RunLength = row.Field<int>("RunLength"),
                        IsClassic = row.Field<bool>("IsClassic")
                    };
                    //DBNull.Value
                    var genre = !row.IsNull("Genre") ? row.Field<string>("Genre") : null;
                    //var genre = row.Field<string>("Genre");
                    if (!String.IsNullOrEmpty(genre))
                        movie.Genre = new Genre(genre);

                    items.Add(movie);
                };
            };
                return items;
        }

        private SqlConnection OpenConnection ()
        {
            var conn = new SqlConnection(_connectionString);
            
            conn.Open();

            return conn;
                //TODO: Later
        }

        protected override Movie GetCore(int id) => FindById(id);

        protected override void UpdateCore ( int id, Movie movie )
        {
            using (var conn = OpenConnection())
            {
                var cmd = new SqlCommand("UpdateMovie", conn);
                //var cmd2 = conn.CreateCommand();
                //cmd.CommandText = "AddMovie";
                //TODO logic
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                //Add parameters
                //1 long way
                var pName = new SqlParameter("@name", movie.Title);
                cmd.Parameters.Add(pName);

                //2 shorter way
                var pGenre = cmd.Parameters.Add("@genre", System.Data.SqlDbType.NVarChar);
                if (movie.Genre != null)
                    pGenre.Value = movie.Genre.Description;

                //3. Short short version
                cmd.Parameters.AddWithValue("@description", movie.Description);
                cmd.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
                cmd.Parameters.AddWithValue("@runLength", movie.RunLength);
                cmd.Parameters.AddWithValue("@IsClassic", movie.IsClassic);

                //Executes the cmd and returns back the first value of the first row, if any
                cmd.ExecuteNonQuery();
            };
        }

        private readonly string _connectionString;

    }
}
