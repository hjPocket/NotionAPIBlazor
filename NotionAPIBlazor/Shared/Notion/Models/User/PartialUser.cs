
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.User
{
    public class PartialUser
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("person")]
        public PeopleObject? Person { get; set; }

        [JsonProperty("bot")]
        public BotsObject? Bot { get; set;}
    }
}
