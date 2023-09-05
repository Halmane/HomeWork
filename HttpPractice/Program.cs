using HttpPractice;
using System;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

HttpClient httpClient = new HttpClient();
int page = 0;
using HttpRequestMessage request = new HttpRequestMessage(
    HttpMethod.Post,
    $"https://www.bungie.net/Platform/User/Search/GlobalName/{page}/"
);
var serchUser = JsonContent.Create(new UserSearchPrefixRequest() { DisplayNamePrefix = "Fumee" });
request.Headers.Add("X-API-Key", "bcf113bb1115487baec8fc81b76ffdfd");
request.Content = serchUser;
using HttpResponseMessage responce = await httpClient.SendAsync(request);
var user = JsonSerializer.Deserialize<ResponseMessage>(await responce.Content.ReadAsStringAsync());
int index = choice();

int membershipType = 3;
string destinyMembershipId = user.Response.SearchResults[index].DestinyMemberships[0].MembershipId;

using HttpRequestMessage requestSecond = new HttpRequestMessage(
    HttpMethod.Get,
    $"https://www.bungie.net/Platform/Destiny2/{membershipType}/Profile/{destinyMembershipId}?components=Profiles,Characters"
);
requestSecond.Headers.Add("X-API-Key", "bcf113bb1115487baec8fc81b76ffdfd");
using HttpResponseMessage responceSecond = await httpClient.SendAsync(requestSecond);
var a = await responceSecond.Content.ReadAsStringAsync();

Console.WriteLine(a);
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
