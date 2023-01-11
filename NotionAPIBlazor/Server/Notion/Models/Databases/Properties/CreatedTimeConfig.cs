﻿using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Databases.Properties
{
    public class CreatedTimeConfig : Property
    {
        public override PropertyType Type => PropertyType.CreatedTime;

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }
    }
}
