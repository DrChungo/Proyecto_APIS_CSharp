using System.Text.Json.Serialization;


namespace Models
{
    public class AnimeResponse 
    {
        [JsonPropertyName("data")]
        public List<AnimeData>? Data { get; set; }
    }

    public class AnimeData
    {
        [JsonPropertyName("mal_id")]
        public int? Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; } = "";

        [JsonPropertyName("approved")]
        public bool? Approved { get; set; }


        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("title_english")]
        public string TitleEnglish { get; set; } = "";

        [JsonPropertyName("title_japanese")]
        public string TitleJapanese { get; set; } = "";

        [JsonPropertyName("title_synonyms")]
        public List<string>? TitleSynonyms { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("source")]
        public string Source { get; set; } = "";

        [JsonPropertyName("episodes")]
        public int? Episodes { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = "";

        [JsonPropertyName("airing")]
        public bool? Airing { get; set; }



        [JsonPropertyName("duration")]
        public string Duration { get; set; } = "";

        [JsonPropertyName("rating")]
        public string Rating { get; set; } = "";

        [JsonPropertyName("score")]
        public double? Score { get; set; }

        [JsonPropertyName("scored_by")]
        public int? ScoredBy { get; set; }

        [JsonPropertyName("rank")]
        public int? Rank { get; set; }

        [JsonPropertyName("popularity")]
        public int? Popularity { get; set; }

        [JsonPropertyName("members")]
        public int? Members { get; set; }

        [JsonPropertyName("favorites")]
        public int? Favorites { get; set; }

        [JsonPropertyName("synopsis")]
        public string Synopsis { get; set; } = "";

        [JsonPropertyName("background")]
        public string Background { get; set; } = "";

        [JsonPropertyName("season")]
        public string Season { get; set; } = "";

        [JsonPropertyName("year")]
        public int? Year { get; set; }


        [JsonPropertyName("producers")]
        public List<ItemInfo>? Producers { get; set; }

        [JsonPropertyName("licensors")]
        public List<ItemInfo>? Licensors { get; set; }

        [JsonPropertyName("studios")]
        public List<ItemInfo>? Studios { get; set; }

        [JsonPropertyName("genres")]
        public List<ItemInfo>? Genres { get; set; }

        [JsonPropertyName("explicit_genres")]
        public List<ItemInfo>? ExplicitGenres { get; set; }

        [JsonPropertyName("themes")]
        public List<ItemInfo>? Themes { get; set; }

        [JsonPropertyName("demographics")]
        public List<ItemInfo>? Demographics { get; set; }
    }



    public class ItemInfo
    {
        [JsonPropertyName("mal_id")]
        public int? MalId { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("url")]
        public string Url { get; set; } = "";
    }


}
