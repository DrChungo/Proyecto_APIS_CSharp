using System;
using Models;
using Validations;

namespace Functions
{
    public class Genre
    {
       
        public static void GetGenre(AnimeData anime, string name)
        {

                if (!Validation.IsValid(anime))
            {
                Console.WriteLine("Este anime no tiene géneros disponibles.");
                return;
            }

            Console.WriteLine($"\nGéneros del anime {name}:\n");
            Console.WriteLine(String.Join(", ", anime.Genres!.Select(genre => genre.Name)));


            }
        
    }
}