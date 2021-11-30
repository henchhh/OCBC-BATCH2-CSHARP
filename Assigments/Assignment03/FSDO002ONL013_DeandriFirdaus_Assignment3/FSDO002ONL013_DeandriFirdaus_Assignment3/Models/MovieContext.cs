using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FSDO002ONL013_DeandriFirdaus_Assignment3.Models
{
    public class MovieContext
    {
        MovieItem movieItem = new MovieItem();
        public string ConnectionString { get; set; }
        public MovieContext(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<MovieItem> GetAllMovies()
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movie", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("Id"),
                            name = reader.GetString("Name"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString("Duration"),
                            releaseDate = reader.GetDateTime("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> GetMovie(int id)
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movie WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("Id"),
                            name = reader.GetString("Name"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString("Duration"),
                            releaseDate = reader.GetDateTime("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }
        public List<MovieItem> CreateMovie(MovieItem movieItem)
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO movie VALUES(@Id,@Name,@Genre,@Duration,@ReleaseDate)", conn);
                cmd.Parameters.AddWithValue("@Id", movieItem.id);
                cmd.Parameters.AddWithValue("@Name", movieItem.name);
                cmd.Parameters.AddWithValue("@Genre", movieItem.genre);
                cmd.Parameters.AddWithValue("@Duration", movieItem.duration);
                cmd.Parameters.AddWithValue("@ReleaseDate", movieItem.releaseDate);
                cmd.ExecuteNonQuery();
            }
            return list;
        }

        public List<MovieItem> UpdateMovie(MovieItem movieItem)
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE movie SET Name=@Name,Genre=@Genre,Duration=@Duration,ReleaseDate=@ReleaseDate WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", movieItem.id);
                cmd.Parameters.AddWithValue("@Name", movieItem.name);
                cmd.Parameters.AddWithValue("@Genre", movieItem.genre);
                cmd.Parameters.AddWithValue("@Duration", movieItem.duration);
                cmd.Parameters.AddWithValue("@ReleaseDate", movieItem.releaseDate);
                cmd.ExecuteNonQuery();
            }
            return list;
        }

        public List<MovieItem> DeleteMovie(MovieItem movieItem)
        {
            List<MovieItem> list = new List<MovieItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM movie WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", movieItem.id);
                cmd.ExecuteNonQuery();
            }
            return list;
        }
    }
}
