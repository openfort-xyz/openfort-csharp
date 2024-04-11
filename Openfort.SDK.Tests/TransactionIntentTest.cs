using Openfort.SDK.Model;

namespace Openfort.SDK.Tests;

[TestClass]
public class TransactionIntentTest
{
    private OpenfortClient client = new OpenfortClient(ApiKeys.SecretKey);

    [TestMethod]
    public async Task Update()
    {
        var playerRequest = new PlayerCreateRequest("test");
        var playerResponse = await client.Players.Create(playerRequest);
        var chainId = 80001;
        await client.Accounts.Create(new CreateAccountRequest(chainId, "0xDC91aDF855306A44F4041625328abEAB3887b3b8", playerResponse.Id));

        var contractRequest = new CreateContractRequest("test", chainId, "0x38090d1636069c0ff1af6bc1737fb996b7f63ac0");
        var contractResponse = await client.Contracts.Create(contractRequest);


        var policyStrategy = new PolicyStrategyRequest(SponsorSchema.PayForUser);
        var policyRequest = new CreatePolicyRequest("test", chainId, policyStrategy);
        var policyResponse = await client.Policies.Create(policyRequest);
        var createPolicyRuleRequest = new CreatePolicyRuleRequest(PolicyRuleType.ContractFunctions, contract: contractResponse.Id, functionName: "mint(address)", policy: policyResponse.Id);
        await client.PolicyRules.Create(createPolicyRuleRequest);

        var interactions = new List<Interaction> {
            new Interaction(contract: contractResponse.Id, functionName: "mint", functionArgs: new List<object> { playerResponse.Id }),
            new Interaction(contract: contractResponse.Id, functionName: "mint", functionArgs: new List<object> { playerResponse.Id }),
        };

        var transactionIntentRequest = new CreateTransactionIntentRequest(
            chainId,
            playerResponse.Id,
            policyResponse.Id,
            interactions: interactions
        );

        var transactionIntentResponse = await client.TransactionIntents.Create(transactionIntentRequest);
        Assert.IsNotNull(transactionIntentResponse.Id);
    }
}
