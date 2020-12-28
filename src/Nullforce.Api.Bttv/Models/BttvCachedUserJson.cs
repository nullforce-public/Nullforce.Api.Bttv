using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Nullforce.Api.Bttv.Models
{
    public class BttvCachedUserJson
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("bots")]
        public List<string> Bots { get; set; }

        [JsonPropertyName("channelEmotes")]
        public List<BttvEmoteJson> ChannelEmotes { get; set; }

        [JsonPropertyName("sharedEmotes")]
        public List<BttvSharedEmoteJson> SharedEmotes { get; set; }
    }
}
