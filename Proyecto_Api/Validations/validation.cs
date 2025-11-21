using Models;

namespace Validations
{
    class Validation
    {
        // Valida que la respuesta de anime contenga datos.
        // @param anime  Objeto AnimeResponse recibido desde la API.
        // @return       true si contiene datos válidos, false en caso contrario.
        public static bool IsValid(AnimeResponse? anime)
        {
            if (anime == null || anime.Data == null || anime.Data.Count == 0)
            {
                return false;
            }

            return true;
        }

        // Valida que la respuesta de personajes contenga datos.
        // @param anime  Objeto CharacterResponse recibido desde la API.
        // @return       true si contiene datos válidos, false en caso contrario.
        public static bool IsValid(CharacterResponse? anime)
        {
            if (anime == null || anime.Data == null || anime.Data.Count == 0)
            {
                return false;
            }

            return true;
        }

        // Valida que un objeto AnimeData tenga sus datos esenciales.
        // @param anime  Objeto AnimeData obtenido de la API.
        // @return       true si contiene información válida, false si faltan datos.
        public static bool IsValid(AnimeData? anime)
        {
            if (anime == null || anime.Genres == null)
            {
                return false;
            }

            return true;
        }

        // Valida que un objeto CharacterData tenga sus datos esenciales.
        // @param anime  Objeto CharacterData obtenido de la API.
        // @return       true si contiene información válida, false si faltan datos.
        public static bool IsValid(CharacterData? anime)
        {
            if (anime == null || anime.VoiceActors == null || anime.Role == null)
            {
                return false;
            }

            return true;
        }

        // Valida que una cadena no esté vacía ni nula.
        // @param str  Cadena a evaluar.
        // @return     true si la cadena contiene texto válido, false en caso contrario.
        public static bool IsValid(string? str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            return true;
        }

        // Valida que un número entero nullable sea válido y mayor a 0.
        // @param num  Número a validar.
        // @return     true si el número existe y es mayor que cero, false si no.
        public static bool IsValid(int? num)
        {
            if (!num.HasValue)
            {
                return false;
            }
            else if (num.Value <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
