using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class PhoneNumberConfig : Property 
    {
        public override PropertyType Type => PropertyType.PhoneNumber;

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
