using System;
using Models;
using Validations;

namespace Functions
{
    public class Synopsis
    {
        // Muestra la sinopsis del anime seleccionado.
        // @param anime   Objeto AnimeData que contiene la sinopsis.
        // @param name    Nombre del anime.
        // @return        No devuelve valor; imprime la sinopsis en consola.
        public static void GetSynopsis(AnimeData anime, string name)
        {
            string synopsis = anime.Synopsis;

            if (!Validation.IsValid(synopsis))
            {
                Console.WriteLine("Error, no se encontraron los datos.");
            }

            Console.WriteLine($"Sínoipis del anime {name}:\n");
            Console.WriteLine(synopsis);
        }
    }
}
