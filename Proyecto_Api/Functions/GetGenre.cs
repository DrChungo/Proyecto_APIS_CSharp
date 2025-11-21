using System;
using Models;
using Validations;

namespace Functions
{
    public class Genre
    {
        // Muestra los géneros del anime seleccionado.
        // @param anime   Objeto AnimeData que contiene la lista de géneros.
        // @param name    Nombre del anime.
        // @return        No devuelve valor; imprime los géneros en consola.
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
