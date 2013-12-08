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
        public static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("http://localhost:5040/api/") };

        static void Main()
        {
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Album album = new Album
            {
                Title = "Album title 7",
                Year = "2000",
                Producer = "Producer 7"
            };

            AddAlbum(album);

            Console.WriteLine("Show all albums:");
            foreach (var a in GetAlbums())
            {
                Console.WriteLine("{0} {1} {2} {3}", a.AlbumId, a.Title, a.Year, a.Producer);
            }

            Console.WriteLine("Show album:");
            var currentAlbum = GetAlbum(3);
            Console.WriteLine("{0} {1} {2} {3}", currentAlbum.AlbumId, currentAlbum.Title, currentAlbum.Year, currentAlbum.Producer);

            DeleteAlbum(8);
            DeleteAlbum(7);
            DeleteAlbum(6);

            Console.WriteLine("Update album:");

            Album albumUpdated = new Album
            {
                AlbumId = 5,
                Title = "Album title 7",
                Year = "2000",
                Producer = "Producer 7"
            };
            UpdateAlbum(5, albumUpdated);

            Artist artist = new Artist
            {
                Name = "Name3",
                Country = "Country3",
                DateOfBirth = DateTime.Parse("30/05/1988"),
            };

            AddArtist(artist);

            Console.WriteLine("Show all artists:");
            foreach (var ar in GetArtists())
            {
                Console.WriteLine("{0} {1} {2} {3}", ar.ArtistId, ar.Name, ar.Country, ar.DateOfBirth);
            }

            Console.WriteLine("Show artist:");
            var currentArtist = GetArtist(2);
            Console.WriteLine("{0} {1} {2} {3}", currentArtist.ArtistId, currentArtist.Name, currentArtist.Country, currentArtist.DateOfBirth);

            Console.WriteLine("Update album:");
            var artistUpdate = new Artist
            {
                ArtistId = 2,
                Name = "Name22",
                Country = "Country22",
                DateOfBirth = DateTime.Parse("30/05/1988"),
            };
            UpdateArtist(2, artistUpdate);

            DeleteArtist(1);

            Song song = new Song
            {
                Title = "Song55",
                Genre = "mixed",
                Year = "2014",
                AlbumId = 4,
                ArtistId = 3
            };
            AddSong(song);

            Console.WriteLine("Show all songs:");
            foreach (var s in GetSongs())
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", s.SongId, s.Title, s.Genre, s.Year, s.Album.Title, s.Artist.Name);
            }

            Console.WriteLine("Show song:");
            var currentSong = GetSong(3);
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", currentSong.SongId, currentSong.Title, currentSong.Genre, currentSong.Year, currentSong.Album.Title, currentSong.Artist.Name);

            Console.WriteLine("Update song:");
            Song songUpdated = new Song
            {
                SongId = 4,
                Title = "Song10",
                Genre = "mixed",
                Year = "2014",
                AlbumId = 4,
                ArtistId = 3
            };
            UpdateSong(4, songUpdated);

            DeleteSong(5);

            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
        }

        private static void AddAlbum(Album album)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("Albums", album).Result;
            
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Album added!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static IEnumerable<Album> GetAlbums()
        {
            HttpResponseMessage response = client.GetAsync("Albums").Result;
            if (response.IsSuccessStatusCode)
            {
                var albums = response.Content.ReadAsAsync<IEnumerable<Album>>().Result;
                return albums;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
        }

        private static Album GetAlbum(int id)
        {
            string url = "Albums/" + id;
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                Album album = response.Content.ReadAsAsync<Album>().Result;
                return album;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
        }

        private static void UpdateAlbum(int id, Album album)
        {
            string url = "Albums/" + id;
            HttpResponseMessage response = client.PutAsJsonAsync(url, album).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Album with id {0} updated", id);
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
                Console.WriteLine("Album with id {0} deleted!", id);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static void AddArtist(Artist artist)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("Artists", artist).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Artist added!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static IEnumerable<Artist> GetArtists()
        {
            HttpResponseMessage response = client.GetAsync("Artists").Result;
            if (response.IsSuccessStatusCode)
            {
                var artists = response.Content.ReadAsAsync<IEnumerable<Artist>>().Result;
                return artists;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
        }

        private static Artist GetArtist(int id)
        {
            string url = "Artists/" + id;
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                Artist artist = response.Content.ReadAsAsync<Artist>().Result;
                return artist;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
        }

        private static void UpdateArtist(int id, Artist artist)
        {
            string url = "Artists/" + id;

            HttpResponseMessage response = client.PutAsJsonAsync(url, artist).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Artist with id {0} changed", id);
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
                Console.WriteLine("Artist with id {0} deleted!", id);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static void AddSong(Song song)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("Songs", song).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Song added!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static IEnumerable<Song> GetSongs()
        {
            HttpResponseMessage response = client.GetAsync("Songs").Result;
            if (response.IsSuccessStatusCode)
            {
                var songs = response.Content.ReadAsAsync<IEnumerable<Song>>().Result;
                return songs;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
        }

        private static Song GetSong(int id)
        {
            string url = "Songs/" + id;
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                Song song = response.Content.ReadAsAsync<Song>().Result;
                return song;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return null;
            }
        }

        private static void UpdateSong(int id, Song song)
        {
            string url = "Songs/" + id;

            HttpResponseMessage response = client.PutAsJsonAsync(url, song).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Song with id {0} changed", id);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        private static void DeleteSong(int id)
        {
            string url = "Songs/" + id;
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Song with id {0} deleted!", id);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
}
 