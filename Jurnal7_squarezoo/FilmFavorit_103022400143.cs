using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal7_squarezoo
{
    internal class FilmFavorit_103022400143
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
            string path = Path.Combine(AppContext.BaseDirectory, "jurnal7_1_103022400143.json");

            string json = File.ReadAllText(path);

            FilmFavorit_103022400143? filmFavorit_103022400143 = JsonSerializer.Deserialize<FilmFavorit_103022400143>(json);

            if (filmFavorit_103022400143 is null)
            {
                Console.WriteLine("Data film tidak dapat dibaca");
            }

            Console.WriteLine($"Film {filmFavorit_103022400143.title} - {filmFavorit_103022400143.director}");
            Console.WriteLine($"\t-{filmFavorit_103022400143.year}");
            Console.WriteLine($"\t-{filmFavorit_103022400143.genre}");
            Console.WriteLine($"\t-{filmFavorit_103022400143.rating}");
            Console.WriteLine($"\t-{filmFavorit_103022400143.durationMinutes}");
            Console.WriteLine($"\t-{filmFavorit_103022400143.isWatched}");
        }
    }
}