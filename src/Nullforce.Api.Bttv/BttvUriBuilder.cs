using Flurl;

namespace Nullforce.Api.Bttv
{
    public static class BttvUriBuilder
    {
        public const string BaseUri = "https://api.betterttv.net/3";

        public static string GetCachedGlobalEmotesUri()
        {
            return BaseUri
                .AppendPathSegment("cached/emotes/global");
        }

        public static string GetCachedTwitchUserUri(string twitchId)
        {
            return BaseUri
                .AppendPathSegment($"cached/users/twitch/{twitchId}");
        }

        public static string SearchSharedEmotesUri(string query)
        {
            return BaseUri
                .AppendPathSegment("emotes/shared/search")
                .SetQueryParam("query", query);
        }
    }
}
