using System;
using System.Text.Json.Serialization;

namespace Nullforce.Api.Bttv.Models
{
    public class BttvUserJson
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
    }
}
