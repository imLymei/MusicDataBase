using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDataBase
{
    internal class AlbumsDAO
    {
        string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=music";

        public List<Album> getAllAlbums()
        {
            // Create a empty list
            List<Album> List = new List<Album>();

            // Connect to mySQL server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // SQL querry command
            MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS", connection);

            // Read SQL data using command query
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album MyAlbum = new Album
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Artist = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        Image = reader.GetString(4),
                        Description = reader.GetString(5),
                    };

                    List.Add(MyAlbum);
                }
            }

            connection.Close();
            return List;
        }
    }
}
