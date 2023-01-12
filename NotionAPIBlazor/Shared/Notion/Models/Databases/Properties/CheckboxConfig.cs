﻿using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class CheckboxConfig : Property
    {
        public override PropertyType Type => PropertyType.Checkbox;

        [JsonProperty("Checkbox")]
        public string Checkbox { get; set; }
    }
}