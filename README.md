# Nullforce.Api.Bttv
A .NET Standard library for consuming Better TTV API endpoints.

|||
----------------------|---
**Build**             | [![Build Status](https://github.com/nullforce-public/Nullforce.Api.Bttv/workflows/build/badge.svg?branch=main)](https://github.com/nullforce-public/Nullforce.Api.Bttv/actions)
**NuGet**             | [![nuget](https://img.shields.io/nuget/v/Nullforce.Api.Bttv.svg)](https://www.nuget.org/packages/Nullforce.Api.Bttv/)
**NuGet (prerelease)**| [![nuget](https://img.shields.io/nuget/vpre/Nullforce.Api.Bttv.svg)](https://www.nuget.org/packages/Nullforce.Api.Bttv/)


## Usage Example

An example using [Flurl.Http](https://flurl.dev/):

Install the `Nullforce.Api.Bttv` package from NuGet (allow prerelease as needed).

```csharp
using Flurl;
using Flurl.Http;
using Nullforce.Api.Bttv;

...

var uri = BttvUriBuilder.GetCachedGlobalEmotesUri();

var results = await uri.GetJsonAsync<List<BttvEmoteJson>>();

foreach (var emote in results)
{
    Console.WriteLine($"Emote Code: {emote.Code} Id: {emote.Id}");
}
```

[More Examples](docs/examples.md)

## Building / Contributing

TBD
