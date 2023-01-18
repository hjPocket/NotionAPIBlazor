
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NotionAPIBlazor.Shared.Notion.Models.User
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(PeopleObject), UserType.Person)]
    [JsonSubtypes.KnownSubType(typeof(BotsObject), UserType.Bot)]
    public class UserStruct
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
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual UserType Type { get; set; }
    }
}
