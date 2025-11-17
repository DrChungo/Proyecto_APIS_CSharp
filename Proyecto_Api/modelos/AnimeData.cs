using System.Text.Json.Serialization;

namespace Modelos
{
    public class Anime
    {
        [JsonPropertyName("mal_id")]
        public int Id { get; set; }

        [JsonPropertyName("title_english")]
        public string TitleEnglish { get; set; } = string.Empty;
    }
}
