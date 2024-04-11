using Openfort.SDK.Model;
using Openfort.SDK.Client;

namespace Openfort.SDK.Tests;

[TestClass]
public class PlayerTest
{
    private OpenfortClient client = new OpenfortClient(ApiKeys.SecretKey);

    [TestMethod]
    public async Task Create()
    {
        var request = new PlayerCreateRequest("test");
        var response = await client.Players.Create(request);

        Assert.AreEqual(response.Name, "test", "Player name is not set correctly");
    }

    [TestMethod]
    public async Task Update()
    {
        var request = new PlayerCreateRequest("test");
        var response = await client.Players.Create(request);

        var updateRequest = new UpdatePlayerRequest(response.Id, "updated name");
        var updateResponse = await client.Players.Update(updateRequest);
        Assert.AreEqual(updateResponse.Name, "updated name", "Player name was not updated");
    }

    [TestMethod]
    [ExpectedException(typeof(ApiException), "Request has invalid parameters. No player found.")]
    public async Task Delete()
    {
        var request = new PlayerCreateRequest("test");
        var response = await client.Players.Create(request);

        var deleteResponse = await client.Players.Delete(response.Id);
        Assert.AreEqual(deleteResponse.Deleted, true, "Player was not deleted");

        var getRequest = new PlayerRequest(response.Id);
        await client.Players.Get(getRequest);
    }
}
