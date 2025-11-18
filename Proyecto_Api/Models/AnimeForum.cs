using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Models
{
    public class ForumResponse
    {
        [JsonPropertyName("data")]
        public List<ForumEntry> Data { get; set; }
    }

    public class ForumEntry
    {
        [JsonPropertyName("mal_id")]
        public int MalId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("author_username")]
        public string AuthorUsername { get; set; }

        [JsonPropertyName("author_url")]
        public string AuthorUrl { get; set; }

        [JsonPropertyName("comments")]
        public int Comments { get; set; }

        [JsonPropertyName("last_comment")]
        public LastComment LastComment { get; set; }
    }

    public class LastComment
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("author_username")]
        public string AuthorUsername { get; set; }

        [JsonPropertyName("author_url")]
        public string AuthorUrl { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }
    }
}
