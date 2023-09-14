// See https://aka.ms/new-console-template for more information
using Openfort.SDK.Model;

Console.WriteLine("Hello, World!");

var client = new Openfort.SDK.OpenfortClient("sk_test_d4d75b24-2205-5ff7-8e71-076e83945ba8");
var players = await client.Players.List();
Console.WriteLine(players.Data.Count);

var request = new AccountListRequest("pla_e8c6a205-ecf1-4ba4-861b-f8b2dbda06c3");
var accounts = await client.Accounts.List(request);
Console.WriteLine(accounts.Data.Count);