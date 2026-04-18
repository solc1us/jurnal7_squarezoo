using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jurnal7_squarezoo
{
    internal class GenreDictionary
    {
        public string category { get; set; } = "";
        public GenreInfo GenreInfo { get; set; } = new GenreInfo();
    }
    internal class GenreInfo
    {
        public string id { get; set; } = "";
        public string name { get; set; } = "";
        public string description { get; set; } = "";
        public List<string> popularMovies { get; set; } = new List<string>();
    }

    internal class GenreDictionary_103022400025
    {
        public GenreDictionary GenreDictionary { get; set; } = new GenreDictionary();

        public void ReadJSON()
        {
            // Ini path buat ambil file json
            string path = Path.Combine(AppContext.BaseDirectory, "jurnal7_3_103022400025.json");
            string json = File.ReadAllText(path);
            // Deserialize
            GenreDictionary_103022400025 genreDictionary_103022400025 = JsonSerializer.Deserialize<GenreDictionary_103022400025>(json);
            // Cek dulu ada apa ngga
            if (genreDictionary_103022400025 is null)
            {
                Console.WriteLine("Data genre tidak dapat dibaca");
            }
            // Print genre info id
            Console.WriteLine($"ID: {genreDictionary_103022400025.GenreDictionary.GenreInfo.id}");
            Console.WriteLine($"Name: {genreDictionary_103022400025.GenreDictionary.GenreInfo.name}");
            Console.WriteLine($"Description: {genreDictionary_103022400025.GenreDictionary.GenreInfo.name}");
            Console.Write($"Popular Movies: ");
            for (int i = 0; i < genreDictionary_103022400025.GenreDictionary.GenreInfo.popularMovies.Count; i++)
            {
                Console.Write($"{genreDictionary_103022400025.GenreDictionary.GenreInfo.popularMovies[i]}, ");
            }
        }
    }
}
