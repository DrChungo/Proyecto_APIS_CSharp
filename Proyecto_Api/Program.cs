using System;
using System.Text.Json;
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

                    AnimeData animeSelected = anime?.Data?.FirstOrDefault() ?? new AnimeData();

                    if (!Validation.IsValid(animeSelected))
                    {
                        Console.WriteLine($"Error, no se reciben los datos del anime {animeSelected}.");
                        continue;
                    }

                    int id = animeSelected.Id ?? 0;
                    string name = animeSelected.Title;

                    if (!Validation.IsValid(id) || !Validation.IsValid(name))
                    {
                        Console.WriteLine($"\nError, no se han encontrado datos de {name}.");
                        continue;
                    }


                    Console.WriteLine($"\nHas elegido el anime {name}.");
                    int option=0;

                    do
                    {
                        Console.WriteLine("\n\n1) Mostrar información básica del anime\n2) Mostrar sinopsis \n3) Mostrar géneros\n4) Mostrar personajes\n5) Elegir otro anime\n6) Cerrar programa");
                        Console.Write("\nElige una opción: ");
                        string? input = Console.ReadLine();
                        option = ValidationNumber.AskForNumber(input);

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
                                break;
                            case 6:
                                Console.WriteLine("Saliendo del programa...");
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Solo puedes elegir una opción del 1 al 6.");
                                break;
                        }

                    } while (option != 5);

                }

                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Error en la solicitud: {e.Message}");
                }



            }
        }
    }
}