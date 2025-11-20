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

        [JsonPropertyName("images")]
        public AnimeImages? Images { get; set; }

        [JsonPropertyName("trailer")]
        public Trailer? Trailer { get; set; }

        [JsonPropertyName("approved")]
        public bool? Approved { get; set; }

        [JsonPropertyName("titles")]
        public List<Title>? Titles { get; set; }

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

        [JsonPropertyName("aired")]
        public Aired? Aired { get; set; }

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

        [JsonPropertyName("broadcast")]
        public Broadcast? Broadcast { get; set; }

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

    public class AnimeImages
    {
        [JsonPropertyName("jpg")]
        public ImageData? Jpg { get; set; }

        [JsonPropertyName("webp")]
        public ImageData? Webp { get; set; }
    }

    public class ImageData
    {
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; } = "";

        [JsonPropertyName("small_image_url")]
        public string SmallImageUrl { get; set; } = "";

        [JsonPropertyName("large_image_url")]
        public string LargeImageUrl { get; set; } = "";
    }

    public class Trailer
    {
        [JsonPropertyName("youtube_id")]
        public string YoutubeId { get; set; } = "";

        [JsonPropertyName("url")]
        public string Url { get; set; } = "";

        [JsonPropertyName("embed_url")]
        public string EmbedUrl { get; set; } = "";
    }

    public class Title
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("title")]
        public string Name { get; set; } = "";
    }

    public class Aired
    {
        [JsonPropertyName("from")]
        public string From { get; set; } = "";

        [JsonPropertyName("to")]
        public string To { get; set; } = "";

        [JsonPropertyName("prop")]
        public AiredProp? Prop { get; set; }
    }

    public class AiredProp
    {
        [JsonPropertyName("from")]
        public DateProp? From { get; set; }

        [JsonPropertyName("to")]
        public DateProp? To { get; set; }

        [JsonPropertyName("string")]
        public string String { get; set; } = "";
    }

    public class DateProp
    {
        [JsonPropertyName("day")]
        public int? Day { get; set; }

        [JsonPropertyName("month")]
        public int? Month { get; set; }

        [JsonPropertyName("year")]
        public int? Year { get; set; }
    }

    public class Broadcast
    {
        [JsonPropertyName("day")]
        public string Day { get; set; } = "";

        [JsonPropertyName("time")]
        public string Time { get; set; } = "";

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; } = "";

        [JsonPropertyName("string")]
        public string String { get; set; } = "";
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

    public class Pagination
    {
        [JsonPropertyName("last_visible_page")]
        public int? LastVisiblePage { get; set; }

        [JsonPropertyName("has_next_page")]
        public bool? HasNextPage { get; set; }

        [JsonPropertyName("current_page")]
        public int? CurrentPage { get; set; }

        [JsonPropertyName("items")]
        public PaginationItems? Items { get; set; }
    }

    public class PaginationItems
    {
        [JsonPropertyName("count")]
        public int? Count { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }

        [JsonPropertyName("per_page")]
        public int? PerPage { get; set; }
    }
}
