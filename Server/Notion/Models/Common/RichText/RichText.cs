﻿using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NotionAPIBlazor.Server.Notion.Models.Common;

namespace NotionAPIBlazor.Server.Notion.Models.Common.RichText
{
    //type의 타입 별로 세팅 (Notion Task(Notion API > RichText 토글) 참고)
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(TextType), RichTextType.Text)]
    [JsonSubtypes.KnownSubType(typeof(MentionType), RichTextType.Mention)]
    [JsonSubtypes.KnownSubType(typeof(EquationType), RichTextType.Equation)]
    public class RichText
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual RichTextType Type { get; set; }

        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("annotations")]
        public Annotation Annotaion { get; set; }
    }
}
