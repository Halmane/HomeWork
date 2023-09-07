using HttpPractice;
using System;
using System.IO;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Serialization;


var request = new HttpRequest();




var page = 0;
var response = await request.Request<ResponseMessage<UserSearchResponse>>(
    HttpMethod.Post,
    $"User/Search/GlobalName/{page}",
    JsonContent.Create(new UserSearchPrefixRequest() { DisplayNamePrefix = "Fumee" })
);

var membershipType = 3;
var index = ChooseAccount(response);
var destinyMembershipId = response.Response.SearchResults[index].DestinyMemberships[0].MembershipId;

var profile = request.Request<ResponseMessage<DestinyProfileResponse>>(
    HttpMethod.Get,
    $"Destiny2/{membershipType}/Profile/{destinyMembershipId}?components=Profiles,Characters"
);

foreach (var (characterId, characterInfo) in profile.Result.Response.characters.Data)
{
    Console.WriteLine(
        $"{characterId}:{characterInfo.GenderType} {characterInfo.RaceType} {characterInfo.ClassType}  Level: {characterInfo.Light}"
    );
}

var listOfPlayers = new List<(int membershipType, long destinyMembershipId)>
{
    (3, 4611686018514469726),
    (3, 4611686018519131912),
    (3, 4611686018507520201),
    (3, 4611686018499749567),
    (3, 4611686018483245155)
};

foreach (var player in listOfPlayers)
{
    var playerProfile = request.Request<ResponseMessage<DestinyProfileResponse>>(
        HttpMethod.Get,
        $"Destiny2/{player.membershipType}/Profile/{player.destinyMembershipId}?components=Profiles,Characters"
    );
    Console.WriteLine();
    foreach (var (characterId, characterInfo) in playerProfile.Result.Response.characters.Data)
    {
        Console.WriteLine(
            $"{characterId}:{characterInfo.GenderType} {characterInfo.RaceType} {characterInfo.ClassType}  Level: {characterInfo.Light}"
        );
    }
}

int ChooseAccount(ResponseMessage<UserSearchResponse> message)
{
    for (int i = 0; i < message.Response.SearchResults.Length; i++)
    {
        Console.WriteLine($"{i + 1} {message.Response.SearchResults[i].DungieGlobalDisplayName}");
    }
    int number = -1;
    var stringNumber = String.Empty;

    do
    {
        Console.WriteLine("Enter number:");
        stringNumber = Console.ReadLine();
    } while (
        int.TryParse(stringNumber, out number)
        && (number <= 0 || number > message.Response.SearchResults.Length)
    );
    return number - 1;
}
