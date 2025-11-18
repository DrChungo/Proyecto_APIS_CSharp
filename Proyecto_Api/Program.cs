using System;
using System.Text.Json;
using Models;
using Functions;


namespace EjerciciosCSharp
{
    class Program
    {
        static async Task Main()
        {

            while (true)
            {


                using (HttpClient client = new HttpClient())

                {
                    Console.Write("Ingresa el nombre del anime: ");
                    string animeName = Console.ReadLine() ?? "";
                    string url = $"https://api.jikan.moe/v4/anime?q={Uri.EscapeDataString(animeName)}&limit=1";


                    try
                    {

                      
                        AnimeResponse? anime = await GetJson.GetJsonAsync(url);

                        int id = anime.Data.First().Id;
                        string name = anime.Data.First().Title;
                    


                        Console.WriteLine($"\nHas elegido el anime {name}.");
                        Console.WriteLine("\nQué deseas hacer a continuación?\n1) Mostrar ranking\n2) Mostrar sinopsis \n3) Mostrar género\n 4) Mostrar información de un personaje");
                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                Console.WriteLine($"El ranking del anime es {Ranking.GetRanking(anime)}");
                                break;


                            default:
                                Console.WriteLine("Solo puedes elegir una opción del 1 al 4.");
                                break;
                        }

                    }
                    catch (HttpRequestException e)
                    {
                        Console.WriteLine($"Error en la solicitud: {e.Message}");
                    }


                }
            }
        }
    }
}