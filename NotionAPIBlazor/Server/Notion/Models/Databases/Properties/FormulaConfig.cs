using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Databases.Properties
{
    public class FormulaConfig : Property
    {
        public override PropertyType Type => PropertyType.Formula;

        [JsonProperty("formula")]
        public FormulaType Formula { get; set; }
    }

    public class FormulaType
    {
        [JsonProperty("expression")]
        public string Expression { get; set; }
    }
}
