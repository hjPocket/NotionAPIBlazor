﻿using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace NotionAPIBlazor.Shared.Notion.Api
{
    internal static class HttpExtensions
    {
        internal static async Task<T> ParseStreamAsync<T>(
            this HttpResponseMessage httpResponseMessage,
            JsonSerializerSettings jsonSerializerSettings)
        {
            string _string = await httpResponseMessage.Content.ReadAsStringAsync();
            var stream = await httpResponseMessage.Content.ReadAsStreamAsync();
            var streamReader = new StreamReader(stream);
            JsonReader jsonReader = new JsonTextReader(streamReader);

            var serializer = jsonSerializerSettings == null ? JsonSerializer.CreateDefault() : JsonSerializer.Create(jsonSerializerSettings);

            Console.WriteLine(_string);
            return serializer.Deserialize<T>(jsonReader);
        }
    }
}
