using System;
using System.Data.Entity;
using Music.Data;
using Music.Models;
using Music.Data.Migrations;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Globalization;

namespace Music.Client
{
    public class Program
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("http://localhost:5040/api/") };

        static void Main()
        {
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //// Test Post method in Albums
            //AddNewAlbum("NewAlbumName", "2011", "Goshko");   
       
            ////Test Get methods in Albums
            //ViewAlbum();
            //ViewAlbum(1);

            ////Test Put method in Albums
            //UpdateAlbum(7, "ChangeName", "1999", "Ivancho");

            ////Test Delete method in Albums
            //DeleteAlbum(2);

            ////Test methods in Artist
            //AddNewArtist("Kumba", "Zimbabve", "15/06/1988");
            //AddNewArtist("Pumba", "Japan", "15/06/2000");
            //ViewArtist();
            //ViewArtist(9);
            //UpdateArtist(5, "NewKumba", "Zimbabve", "15/06/1988");
            //DeleteArtist(7);

        }

        private static void AddNewAlbum(string title, string year, string producer)
        {
            Album newAlbum = new Album
            {
                Title = title,
                Year = year,
                Producer = producer
            };

            HttpResponseMessage response = client.PostAsJsonAsync("Albums", newAlbum).Result; 
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Album added!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static void ViewAlbum(params int[] id)
        {
            if (id == null || id.Length == 0)
            {
                HttpResponseMessage response = client.GetAsync("Albums").Result;
                if (response.IsSuccessStatusCode)
                {
                    var albums = response.Content.ReadAsAsync<IEnumerable<Album>>().Result;
                    foreach (var album in albums)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", album.AlbumId, album.Title, album.Year, album.Producer);
                    }
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }
            }
            else if (id.Length == 1)
            {
                string url = "Albums/" + id[0];
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    Album album = response.Content.ReadAsAsync<Album>().Result;
                    Console.WriteLine("{0} {1} {2} {3}", album.AlbumId, album.Title, album.Year, album.Producer);

                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }
            }
            else
            {
                throw new ArgumentException("The argument must be only one!");
            }
        }

        private static void UpdateAlbum(int id, string title, string year, string producer)
        {
            Album updatedAlbum = new Album
            {
                AlbumId = id,
                Title = title,
                Year = year,
                Producer = producer
            };
            
            string url = "Albums/" + id;
            HttpResponseMessage response = client.PutAsJsonAsync(url, updatedAlbum).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Album changed");
                ViewAlbum(id);

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static void DeleteAlbum(int id)
        {
            string url = "Albums/" + id;
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Album deleted!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static void AddNewArtist(string name, string country, string dateOfBirth)
        {
            Artist newArtist = new Artist
            {
                Name = name,
                Country = country,
                DateOfBirth = DateTime.Parse(dateOfBirth)
            };

            HttpResponseMessage response = client.PostAsJsonAsync("Artists", newArtist).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Artist added!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static void ViewArtist(params int[] id)
        {
            if (id == null || id.Length == 0)
            {
                HttpResponseMessage response = client.GetAsync("Artists").Result;
                if (response.IsSuccessStatusCode)
                {
                    var artists = response.Content.ReadAsAsync<IEnumerable<Artist>>().Result;
                    foreach (var artist in artists)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", artist.ArtistId, artist.Name, artist.Country, artist.DateOfBirth);
                    }
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }
            }
            else if (id.Length == 1)
            {
                string url = "Artists/" + id[0];
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    Artist artist = response.Content.ReadAsAsync<Artist>().Result;
                    Console.WriteLine("{0} {1} {2} {3}", artist.ArtistId, artist.Name, artist.Country, artist.DateOfBirth);

                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }
            }
            else
            {
                throw new ArgumentException("The argument must be only one!");
            }
        }

        private static void UpdateArtist(int id, string name, string country, string dateOfBirth)
        {
            Artist updateArtist = new Artist
            {
                ArtistId = id,
                Name = name,
                Country = country,
                DateOfBirth = DateTime.Parse(dateOfBirth)
            };

            string url = "Artists/" + id;
            HttpResponseMessage response = client.PutAsJsonAsync(url, updateArtist).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Artist with id {0} changed", id);
                ViewArtist(id);

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static void DeleteArtist(int id)
        {
            string url = "Artists/" + id;
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Artist deleted!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
}
 