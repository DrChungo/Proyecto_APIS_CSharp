using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Models
{
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
        public string? Role { get; set; }

        [JsonPropertyName("voice_actors")]
        public List<VoiceActor>? VoiceActors { get; set; }
    }

    public class Character
    {
        [JsonPropertyName("mal_id")]
        public int MalId { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("images")]
        public CharacterImages? Images { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class CharacterImages
    {
        [JsonPropertyName("jpg")]
        public CharacterImageData? Jpg { get; set; }

        [JsonPropertyName("webp")]
        public CharacterImageData? Webp { get; set; }
    }

    public class CharacterImageData
    {
        [JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        [JsonPropertyName("small_image_url")]
        public string? SmallImageUrl { get; set; }
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

        [JsonPropertyName("images")]
        public PersonImages? Images { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class PersonImages
    {
        [JsonPropertyName("jpg")]
        public object? Jpg { get; set; }
    }
}
