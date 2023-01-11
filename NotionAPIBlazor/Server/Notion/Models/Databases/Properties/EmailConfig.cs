﻿using Newtonsoft.Json;

namespace NotionAPIBlazor.Server.Notion.Models.Databases.Properties
{
    public class EmailConfig : Property
    {
        public override PropertyType Type => PropertyType.Email;

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
