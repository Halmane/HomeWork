using HttpPractice;
using System;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

var httpClient = new HttpClient();
var bungie = "https://www.bungie.net/Platform/";

var page = 0;
using var request = new HttpRequestMessage(
    HttpMethod.Post,
    $"{bungie}User/Search/GlobalName/{page}/"
);
request.Headers.Add("X-API-Key", "bcf113bb1115487baec8fc81b76ffdfd");
request.Content = JsonContent.Create(new UserSearchPrefixRequest() { DisplayNamePrefix = "Fumee" });
var user = JsonSerializer.Deserialize<ResponseMessage<UserSearchResponse>>(
    await (await httpClient.SendAsync(request)).Content.ReadAsStringAsync()
);

int index = choice();

var membershipType = 3;
var destinyMembershipId = user.Response.SearchResults[index].DestinyMemberships[0].MembershipId;

using var requestSecond = new HttpRequestMessage(
    HttpMethod.Get,
    $"{bungie}Destiny2/{membershipType}/Profile/{destinyMembershipId}?components=Profiles,Characters"
);
requestSecond.Headers.Add("X-API-Key", "bcf113bb1115487baec8fc81b76ffdfd");
var a = JsonSerializer.Deserialize<ResponseMessage<DestinyProfileResponse>>(
    await (await httpClient.SendAsync(requestSecond)).Content.ReadAsStringAsync()
);

foreach (var (characterId, characterInfo) in a.Response.characters.Data)
{
    Console.WriteLine(
        $"{characterId}:{characterInfo.GenderType} {characterInfo.RaceType} {characterInfo.ClassType}  Level: {characterInfo.Light}"
    );
}
int choice()
{
    for (int i = 0; i < user.Response.SearchResults.Length; i++)
    {
        Console.WriteLine($"{i + 1} {user.Response.SearchResults[i].DungieGlobalDisplayName}");
    }
    int number = -1;
    var stringNumber = String.Empty;

    do
    {
        Console.WriteLine("Enter number:");
        stringNumber = Console.ReadLine();
    } while (
        int.TryParse(stringNumber, out number)
        && (number <= 0 || number > user.Response.SearchResults.Length)
    );
    return number - 1;
}
