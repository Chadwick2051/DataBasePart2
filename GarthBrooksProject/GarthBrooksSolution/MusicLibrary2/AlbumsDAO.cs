using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicLibrary2
{
    public class AlbumsDAO
    {
        //public List<Album> albums = new List<Album>();

        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GarthDB;Integrated Security=SSPI";

        public List<Album> GetAllAlbums()
        {
            string term = "";

            //Start w/ empty list
            List<Album> albumsToReturn = new List<Album>();

            //Attempt Connection to SQL server
            SqlConnection connection = new SqlConnection(connString);

            //Open Server connection
            connection.Open();

            string searchPhrase = "%" + term + "%";

            //define SQL statement to get all albums
            SqlCommand command = new SqlCommand();
            command.CommandText =
                "SELECT * FROM albums WHERE AlbumName LIKE @term";
            command.Parameters.AddWithValue("@term", searchPhrase);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                //build albums in Album class
                while(reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumArtist = reader.GetString(2),
                        AlbumYear = reader.GetInt32(3),
                        AlbumDesc = reader.GetString(4),
                        AlbumURL = reader.GetString(5),
                    };

                    albumsToReturn.Add(a);
                }
            }
            //Clsoe connection to server
            connection.Close();

            return albumsToReturn;
        }

        public List<Album> GetSearchAlbums(string search)
        {
            //Start w/ empty list
            List<Album> albumsToReturn = new List<Album>();

            //Attempt Connection to SQL server
            SqlConnection connection = new SqlConnection(connString);

            //Open Server connection
            connection.Open();

            string searchPhrase = "%" + search + "%";

            //define SQL statement to get all albums
            SqlCommand command = new SqlCommand();
            command.CommandText =
                "SELECT * FROM albums WHERE AlbumName LIKE @search";
            command.Parameters.AddWithValue("@search", searchPhrase);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                //build albums in Album class
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumArtist = reader.GetString(2),
                        AlbumYear = reader.GetInt32(3),
                        AlbumDesc = reader.GetString(4),
                        AlbumURL = reader.GetString(5),
                    };

                    albumsToReturn.Add(a);
                }
            }
            //Clsoe connection to server
            connection.Close();

            return albumsToReturn;
        }
    }
}
