using System.Text.Json.Serialization;

namespace Models
{
    // Modelo que representa la respuesta de personajes enviada por la API.
    // Contiene una lista de CharacterData.
    public class CharacterResponse 
    {
        [JsonPropertyName("data")]
        public List<CharacterData>? Data { get; set; }
    }


    public class CharacterData
    {
        [JsonPropertyName("character")]
        public Character? Character { get; set; }

        [JsonPropertyName("role")]
        public string? Role { get; set; } = "";

        [JsonPropertyName("voice_actors")]
        public List<VoiceActor> VoiceActors { get; set; } = new List<VoiceActor>();
    }

    
    public class Character
    {
        [JsonPropertyName("mal_id")]
        public int MalId { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class VoiceActor
    {
        [JsonPropertyName("person")]
        public Person? Person { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }
    }


    public class Person
    {
        [JsonPropertyName("mal_id")]
        public int MalId { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
