using Models;
using Functions;
using Validations;


namespace EjerciciosCSharp
{
    class Program
    {
        static async Task Main()
        {

            while (true)
            {

                Console.Write("\nIngresa el nombre del anime: ");
                string animeName = Console.ReadLine() ?? "";
                string url = $"https://api.jikan.moe/v4/anime?q={Uri.EscapeDataString(animeName)}&limit=1";

                try
                {

                    AnimeResponse? anime = await GetJson.GetJsonAsync<AnimeResponse>(url);

                    if (!Validation.IsValid(anime))
                    {
                        Console.WriteLine("Error, no se reciben los datos.");
                        continue;
                    }

                    AnimeData? animeSelected = anime?.Data?.FirstOrDefault();

                    if (!Validation.IsValid(animeSelected) || !Validation.IsValid(animeSelected?.Id))
                    {
                        Console.WriteLine("No se encontraron datos válidos del anime.");
                        continue;
                    }


                    int id = animeSelected!.Id!.Value;
                    string name = animeSelected.Title;

                    if (!Validation.IsValid(id) || !Validation.IsValid(name))
                    {
                        Console.WriteLine($"\nError, no se han encontrado datos de {name}.");
                        continue;
                    }


                    Console.WriteLine($"\nHas elegido el anime {name}.");


                    await Show.ShowOptionsAsync(animeSelected, name, id);

                }

                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Error en la solicitud: {e.Message}");
                }



            }
        }
    }
}