using System;
using Models;
using Validations;


namespace Functions
{
    public class Characters
    {
       
        public static async Task GetCharactersAsync(string name, int id)
        {
            string url = $"https://api.jikan.moe/v4/anime/{id}/characters";
            CharacterResponse? animeCharacters = await GetJson.GetJsonAsync<CharacterResponse>(url);

            if (!Validation.IsValid(animeCharacters))
            {
                Console.WriteLine("No se han podido recibir los datos de los personajes.");
                return;
            }

            Console.WriteLine($"\n20 primeros personajes del anime {name}:\n");

            int count=1;

            foreach (var character in animeCharacters!.Data!.Take(20))
            {
                string nameCharacter = character.Character!.Name!;

                if (!Validation.IsValid(nameCharacter))
                {
                    Console.WriteLine("No se ha podido acceder al nombre del personaje.");
                    return;
                }

                Console.WriteLine($"{count}){nameCharacter}");

                count++;

            }

            Console.WriteLine("Quieres seleccionar un personaje en concreto? (s/n)");
            string option="";

        }
    }
}