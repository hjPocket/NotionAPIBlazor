
using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Pages.Properties
{
    public class PagePhoneNumberConfig : PageProperty
    {
        public override PagePropertyType Type => PagePropertyType.PhoneNumber;

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
