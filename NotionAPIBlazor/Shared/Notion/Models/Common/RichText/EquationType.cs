using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Common.RichText
{
    public class EquationType : RichText
    {
        public override RichTextType Type => RichTextType.Equation;

        [JsonProperty("equation")]
        public Equation Equation { get; set; }
    }

    public class Equation
    {
        [JsonProperty("expression")]
        public string Expression { get; set; }
    }
}
