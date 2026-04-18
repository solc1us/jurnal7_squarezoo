using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal7_squarezoo
{
    internal class FilmFavorit_103022400025
    {
        public string title { get; set; } = "";
        public string director { get; set; } = "";
        public string year { get; set; } = "";
        public string genre { get; set; } = "";
        public int rating { get; set; } = 0;
        public int durationMinutes { get; set; } = 0;
        public bool isWatched { get; set; } = false;

        public void readJSON()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "jurnal7_1_103022400025.json");

            string json = File.ReadAllText(path);

            FilmFavorit_103022400025? filmFavorit_103022400025 = JsonSerializer.Deserialize<FilmFavorit_103022400025>(json);

            if (filmFavorit_103022400025 is null)
            {
                Console.WriteLine("Data film tidak dapat dibaca");
            }

            Console.WriteLine($"Film {filmFavorit_103022400025.title} - {filmFavorit_103022400025.director}");
            Console.WriteLine($"\t-{filmFavorit_103022400025.year}");
            Console.WriteLine($"\t-{filmFavorit_103022400025.genre}");
            Console.WriteLine($"\t-{filmFavorit_103022400025.rating}");
            Console.WriteLine($"\t-{filmFavorit_103022400025.durationMinutes}");
            Console.WriteLine($"\t-{filmFavorit_103022400025.isWatched}");
        }
    }
}
