using System;
using Models;

namespace Functions
{
    public class Ranking
    {
        // Función que devuelve el ranking del primer anime en el objeto AnimeRoot
        public static int? GetRanking(AnimeResponse anime)
        {
            try
            {
                return anime.Data[0].Rank;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
