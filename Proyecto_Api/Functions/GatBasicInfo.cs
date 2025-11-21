using Models;
using Validations;

namespace Functions
{
    public class BasicInfo
    {
        // Muestra la información básica del anime seleccionado.
        // @param anime   Objeto AnimeData que contiene los datos básicos del anime.
        // @param name    Nombre del anime.
        // @return        No devuelve valor; imprime la información básica en consola.
        public static void GetBasicInfo(AnimeData anime, string name)
        {
            string japaneseTitle = anime.TitleJapanese;
            int ranking = anime.Rank ?? 0;
            int episodes = anime.Episodes ?? 0;
            string status = anime.Status;

            if (!Validation.IsValid(japaneseTitle) || !Validation.IsValid(ranking) || !Validation.IsValid(episodes) || !Validation.IsValid(status))
            {
                Console.WriteLine("No se encontraron los datos.");
                return;
            }

            Console.WriteLine($"\nInformación básica de {name}: ");
            Console.WriteLine($"\nTítulo japonés: {japaneseTitle}\nRanking: {ranking}\nEpisodios: {episodes}\nEstado: {status}");
        }
    }
}
