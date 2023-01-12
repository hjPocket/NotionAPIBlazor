﻿using Newtonsoft.Json;

namespace NotionAPIBlazor.Shared.Notion.Models.Databases.Properties
{
    public class LastEditedByConfig : Property
    {
        public override PropertyType Type => PropertyType.LastEditedBy;

        [JsonProperty("last_edited_by")]
        public string LastEditedBy { get; set;}
    }
}