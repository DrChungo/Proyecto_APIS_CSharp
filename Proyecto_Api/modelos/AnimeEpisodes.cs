using System.Text.Json.Serialization;

namespace Modelos
{
    public class AnimeEpisodeResponse
    {
        [JsonPropertyName("data")]
        public AnimeEpisode[] Data { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class AnimeEpisode
    {
        [JsonPropertyName("mal_id")]
        public int MalId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("title_japanese")]
        public string TitleJapanese { get; set; }

        [JsonPropertyName("title_romanji")]
        public string TitleRomanji { get; set; }

        [JsonPropertyName("aired")]
        public string Aired { get; set; }

        [JsonPropertyName("score")]
        public double? Score { get; set; }

        [JsonPropertyName("filler")]
        public bool Filler { get; set; }

        [JsonPropertyName("recap")]
        public bool Recap { get; set; }

        [JsonPropertyName("forum_url")]
        public string ForumUrl { get; set; }
    }

    public class Pagination
    {
        [JsonPropertyName("last_visible_page")]
        public int LastVisiblePage { get; set; }

        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }
    }
}

