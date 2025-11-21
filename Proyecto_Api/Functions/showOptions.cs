using Models;
using Validations;

namespace Functions
{
    public class Show
    {
        // Muestra un menú interactivo con opciones relacionadas al anime seleccionado.
        // @param animeSelected   Objeto AnimeData con la información del anime.
        // @param name            Nombre del anime seleccionado.
        // @param id              ID del anime en la API (mal_id).
        // @return                Ejecuta un menú en bucle hasta que el usuario elija
        //                        cambiar de anime o cerrar el programa.
        public static async Task ShowOptionsAsync(AnimeData animeSelected, string name, int id)
        {
            while (true)
            {
                Console.WriteLine("\n1) Mostrar información básica del anime\n2) Mostrar sinopsis \n3) Mostrar géneros\n4) Mostrar personajes\n5) Elegir otro anime\n6) Cerrar programa");
                Console.Write("\nElige una opción: ");
                string? input = Console.ReadLine();
                int option = ValidationNumber.AskForNumber(input);

                switch (option)
                {
                    case 1:
                        BasicInfo.GetBasicInfo(animeSelected, name);
                        break;
                    case 2:
                        Synopsis.GetSynopsis(animeSelected, name);
                        break;
                    case 3:
                        Genre.GetGenre(animeSelected, name);
                        break;
                    case 4:
                        await Characters.GetCharactersAsync(name, id);
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        return;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Solo puedes elegir una opción del 1 al 6.");
                        break;
                }
            }
        }
    }
}
