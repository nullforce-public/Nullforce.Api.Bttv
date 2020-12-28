using System;
using System.Text.Json.Serialization;

namespace Nullforce.Api.Bttv.Models
{
    public class BttvEmoteJson
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set;}

        [JsonPropertyName("imageType")]
        public string ImageType { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    }
}
