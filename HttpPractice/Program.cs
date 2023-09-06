using HttpPractice;
using System;
using System.IO;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Serialization;

var httpClient = new HttpClient();
var bungie = "https://www.bungie.net/Platform/";

var page = 0;
var response = await Request<ResponseMessage<UserSearchResponse>>(
    "Post",
    $"User/Search/GlobalName/{page}",
    JsonContent.Create(new UserSearchPrefixRequest() { DisplayNamePrefix = "Fumee" })
);

var membershipType = 3;
var index = choice();
var destinyMembershipId = response.Response.SearchResults[index].DestinyMemberships[0].MembershipId;

var profile = Request<ResponseMessage<DestinyProfileResponse>>(
    "Get",
    $"Destiny2/{membershipType}/Profile/{destinyMembershipId}?components=Profiles,Characters",
    JsonContent.Create(string.Empty)
);

foreach (var (characterId, characterInfo) in profile.Result.Response.characters.Data)
{
    Console.WriteLine(
        $"{characterId}:{characterInfo.GenderType} {characterInfo.RaceType} {characterInfo.ClassType}  Level: {characterInfo.Light}"
    );
}

var listOfPlayers = new List<(string membershipType, string destinyMembershipId)>
{
    ( "3", "4611686018514469726" ),
    ( "3", "4611686018519131912" ),
    ( "3", "4611686018507520201" ),
    ( "3", "4611686018499749567" ),
    ( "3", "4611686018483245155" )
};

foreach (var player in listOfPlayers)
{
    var playerProfile = Request<ResponseMessage<DestinyProfileResponse>>(
        "Get",
        $"Destiny2/{player.membershipType}/Profile/{player.destinyMembershipId}?components=Profiles,Characters",
        JsonContent.Create(string.Empty)
    );
    Console.WriteLine();
    foreach (var (characterId, characterInfo) in playerProfile.Result.Response.characters.Data)
    {
        Console.WriteLine(
            $"{characterId}:{characterInfo.GenderType} {characterInfo.RaceType} {characterInfo.ClassType}  Level: {characterInfo.Light}"
        );
    }
}

async Task<T> Request<T>(string requestType, string path, JsonContent content)
{
    HttpRequestMessage request;
    if (requestType == "Post")
    {
        request = new HttpRequestMessage(HttpMethod.Post, $"{bungie}{path}");
        request.Content = content;
    }
    else
    {
        request = new HttpRequestMessage(HttpMethod.Get, $"{bungie}{path}");
    }
    request.Headers.Add("X-API-Key", "bcf113bb1115487baec8fc81b76ffdfd");

    var result = (await httpClient.SendAsync(request)).Content.ReadAsStringAsync();
    return JsonSerializer.Deserialize<T>(await result);
}

int choice()
{
    for (int i = 0; i < response.Response.SearchResults.Length; i++)
    {
        Console.WriteLine($"{i + 1} {response.Response.SearchResults[i].DungieGlobalDisplayName}");
    }
    int number = -1;
    var stringNumber = String.Empty;

    do
    {
        Console.WriteLine("Enter number:");
        stringNumber = Console.ReadLine();
    } while (
        int.TryParse(stringNumber, out number)
        && (number <= 0 || number > response.Response.SearchResults.Length)
    );
    return number - 1;
}
