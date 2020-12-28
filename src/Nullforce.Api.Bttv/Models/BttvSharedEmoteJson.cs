using System;
using System.Text.Json.Serialization;

namespace Nullforce.Api.Bttv.Models
{
    public class BttvSharedEmoteJson
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set;}

        [JsonPropertyName("imageType")]
        public string ImageType { get; set; }

        [JsonPropertyName("user")]
        public BttvUserJson User;
    }
}
