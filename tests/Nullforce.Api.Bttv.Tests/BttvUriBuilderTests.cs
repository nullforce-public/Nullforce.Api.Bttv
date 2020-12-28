using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Flurl;
using Flurl.Http;
using Flurl.Http.Testing;
using Nullforce.Api.Bttv;
using Nullforce.Api.Bttv.Models;
using Xunit;

namespace Nullforce.Api.Derpibooru.Tests
{
    public class BttvUriBuilderTests
    {
        public BttvUriBuilderTests()
        {
        }

        [Fact]
        public async Task GetCachedGlobalEmotesUri_ReturnsGolbalEmotes()
        {
            var uri = BttvUriBuilder.GetCachedGlobalEmotesUri();
            var results = await uri.GetJsonAsync<List<BttvEmoteJson>>();

            results.Should().NotBeNull();
        }

        [Fact]
        public async Task GetCachedTwitchUserUri_WithTwitchId_ReturnsUser()
        {
            var twitchId = "7233665";

            var uri = BttvUriBuilder.GetCachedTwitchUserUri(twitchId);
            var results = await uri.GetJsonAsync<BttvCachedUserJson>();

            results.Should().NotBeNull();
        }

        [Fact]
        public async Task SearchSharedEmotesUri_WithQueryParam_ReturnsSharedEmotes()
        {
            var uri = BttvUriBuilder.SearchSharedEmotesUri("lul");
            var results = await uri.GetJsonAsync<List<BttvSharedEmoteJson>>();

            results.Should().NotBeNull();
        }

        [Fact]
        public async Task Test()
        {
            var json = @"[{'id': 'emoteId', 'code': 'lul', 'imageType': 'png', 'user': {'id': '1', 'name': 'nullforce', 'displayName': 'nullforce', 'providerId': 'twitch'}}]";

            using var httpTest = new HttpTest();
            httpTest.RespondWith(json, 200);

            var uri = BttvUriBuilder.SearchSharedEmotesUri("lul");
            var results = await uri.GetJsonAsync<List<BttvSharedEmoteJson>>();

            httpTest.ShouldHaveMadeACall()
                .WithVerb(HttpMethod.Get)
                .WithQueryParam("query", "lul")
                .Times(1);
            results.Should().HaveCount(1);
        }
    }
}
