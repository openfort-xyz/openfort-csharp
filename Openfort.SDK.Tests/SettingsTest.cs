using Openfort.SDK.Model;
using Openfort.SDK.Client;

namespace Openfort.SDK.Tests;

[TestClass]
public class SettingsTest
{
    private OpenfortClient client = new OpenfortClient(ApiKeys.SecretKey);

    [TestMethod]
    public async Task GetDepositorAddresses()
    {
        var response = await client.Settings.GetDepositorAddresses();

        Assert.AreEqual(response.Data.Count, 0, "Depositor addresses were not retrieved");
    }

    [TestMethod]
    [ExpectedException(typeof(ApiException), "equest has invalid parameters. Invalid address: 'test'.")]
    public async Task AddDepositorAddress()
    {
        var request = new PaymasterDepositorCreateRequest("test", "signature");
        await client.Settings.AddDepositorAddress(request);
    }
}
