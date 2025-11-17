
using System.Text.Json.Serialization;


namespace Modelos
{
    public class CharacterListResponse
    {
        [JsonPropertyName("data")]
        public CharacterEntry[] Data { get; set; }
    }

    public class CharacterEntry
    {
        [JsonPropertyName("character")]
        public CharacterInfo Character { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("voice_actors")]
        public VoiceActor[] VoiceActors { get; set; }
    }

    public class CharacterInfo
    {
        [JsonPropertyName("mal_id")]
        public int MalId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("images")]
        public CharacterImages Images { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class CharacterImages
    {
        [JsonPropertyName("jpg")]
        public ImageType Jpg { get; set; }

        [JsonPropertyName("webp")]
        public ImageType Webp { get; set; }
    }

    public class ImageType
    {
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("small_image_url")]
        public string SmallImageUrl { get; set; }

        [JsonPropertyName("large_image_url")]
        public string LargeImageUrl { get; set; }
    }

    public class VoiceActor
    {
        [JsonPropertyName("person")]
        public PersonInfo Person { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }
    }

    public class PersonInfo
    {
        [JsonPropertyName("mal_id")]
        public int MalId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("images")]
        public PersonImages Images { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class PersonImages
    {
        [JsonPropertyName("jpg")]
        public object Jpg { get; set; }
    }

}


