using Models;

namespace Validations
{
    class Validation
    {
        public static bool IsValid(AnimeResponse? anime)
        {
            if (anime == null || anime.Data == null || anime.Data.Count==0)
            {
                return false;
            }

            return true;
            
        }

          public static bool IsValid(CharacterResponse? anime)
        {
            if (anime == null || anime.Data == null || anime.Data.Count==0)
            {
                return false;
            }

            return true;
            
        }

          public static bool IsValid(AnimeData? anime)
        {
            if (anime == null || anime.Genres==null)
            {
                return false;
            }

            return true;
            
        }

              public static bool IsValid(CharacterData? anime)
        {
            if (anime == null || anime.VoiceActors==null || anime.Role==null)
            {
                return false;
            }

            return true;
            
        }

        public static bool IsValid(string? str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            return true;
        }

         public static bool IsValid(int? num)
        {
            if (!num.HasValue)
            {
               return false;

            } else if (num.Value <=0)
            {
                return false;
            }

            return true;
        }


    }
}