using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal7_squarezoo
{
    internal class Movie
    {
        public string id { get; set; } = "";
        public string title { get; set; } = "";
        public int year { get; set; } = 0;
        public string genre { get; set; } = "";
        public double rating { get; set; } = 0.0;
    }
    internal class Watchlist_103022400070
    {

        // Inisialisasi atribut
        public string watchlistName { get; set; } = "";
        public string createdBy { get; set; } = "";
        public List<Movie> movies { get; set; } = new List<Movie>();

        public void readJSON()
        {
            // Ini path buat ambil file json
            string path = Path.Combine(AppContext.BaseDirectory, "jurnal7_2_103022400070.json");
            string json = File.ReadAllText(path);

            // Deserialize
            Watchlist_103022400070 watchlist_103022400070 = JsonSerializer.Deserialize<Watchlist_103022400070>(json);



            // Cek dulu ada apa ngga
            if (watchlist_103022400070 is null)
            {
                Console.WriteLine("Data watchlist tidak dapat dibaca");
            }

            // Print
            Console.WriteLine($"Watchlist Name: {watchlist_103022400070.watchlistName}");
            Console.WriteLine($"Created By: {watchlist_103022400070.createdBy}");
            for (int i = 0; i < watchlist_103022400070.movies.Count; i++)
            {
                Console.WriteLine($"{watchlist_103022400070.movies[i].id} {watchlist_103022400070.movies[i].title} ({watchlist_103022400070.movies[i].year} - {watchlist_103022400070.movies[i].rating})");
            }
        }
    }
}