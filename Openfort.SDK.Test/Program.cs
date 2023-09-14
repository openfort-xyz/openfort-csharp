using Openfort.SDK.Model;

var client = new Openfort.SDK.OpenfortClient("sk_test_XXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX");
var players = await client.Players.List();
Console.WriteLine(players.Data.Count);

if (players.Data.Count > 0)
{
    var request = new AccountListRequest(players.Data[0].Id);
    var accounts = await client.Accounts.List(request);
    Console.WriteLine(accounts.Data.Count);
}