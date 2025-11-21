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

            int count = 1;

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

            Console.WriteLine("\nQuieres ver la información de un personaje en concreto? (s/n)");
            string option = ValidationString.AskForString(Console.ReadLine());

            if (!ValidationOption.AskForOption(option))
            {
                return;
            }
            else
            {

                Console.WriteLine("Ingresa el nombre del personaje: ");
                string userCharacter = ValidationString.AskForString(Console.ReadLine());
                userCharacter = userCharacter.ToLower();


                bool found = false;
                foreach (var character in animeCharacters!.Data!)
                {
                    string nameCharacter = character.Character!.Name!.ToLower();
                    string role = character.Role ?? "";




                    if (!Validation.IsValid(character))
                    {
                        Console.WriteLine("No se han encontrado los actores de voz o roles.");

                    }

                    if (nameCharacter.Contains(userCharacter, StringComparison.InvariantCultureIgnoreCase))
                    {
                        found = true;

                        Console.WriteLine($"\nRol de {nameCharacter}: {role}");
                        Console.WriteLine($"\nActores de voz:");

                        foreach (var va in character.VoiceActors)
                        {
                            string actorName = va.Person?.Name ?? "Desconocido";
                            string language = va.Language ?? "Desconocido";
                            Console.WriteLine($"- Actor de voz: {actorName} | Idioma: {language}");
                        }
                    }

                    
                }

                  if (!found)
                    {
                        Console.WriteLine("No se ha encontrado el personaje");
                        return;
                    }
            }



        }
    }
}