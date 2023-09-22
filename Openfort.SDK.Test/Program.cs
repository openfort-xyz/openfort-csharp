using Openfort.SDK;
using Openfort.SDK.Model;

var client = new OpenfortClient("sk_test_XXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX");
var playerId = await client.createPlayer();
var chainId = 80001;
var contractId = await client.createContract(chainId, "0x38090d1636069c0ff1af6bc1737fb996b7f63ac0");
var policyId = await client.createPolicy(chainId, contractId);

var interactions = new List<Interaction>{
    new Interaction(contract: contractId, functionName: "mint", functionArgs: new List<object> { playerId }),
    new Interaction(contract: contractId, functionName: "mint", functionArgs: new List<object> { playerId }),
};

var transactionIntentRequest = new CreateTransactionIntentRequest(
    playerId,
    chainId,
    policyId,
    interactions: interactions
);

var transactionIntentResponse = await client.TransactionIntents.Create(transactionIntentRequest);
Console.Write(transactionIntentResponse.Id);

static class OpenfortClientExtensions
{
    public static async Task<string> createPlayer(this OpenfortClient client)
    {
        var request = new CreatePlayerRequest("test");
        var response = await client.Players.Create(request);
        return response.Id;
    }

    public static async Task<string> getFirstPlayerId(this OpenfortClient client)
    {
        var request = new PlayerListRequest(1);
        var response = await client.Players.List(request);
        if (response.Data.Count == 0)
        {
            throw new Exception("Players not found");
        }
        return response.Data[0].Id;
    }

    public static async Task<int> getPlayerAccountChainId(this OpenfortClient client, string playerId)
    {
        var request = new AccountListRequest(playerId);
        var response = await client.Accounts.List(request);
        if (response.Data.Count == 0)
        {
            throw new Exception("Account needs to be created");
        }
        return response.Data[0].ChainId;
    }

    public static async Task<string> getFirstPolicyId(this OpenfortClient client, int chainId)
    {
        var request = new PolicyListRequest(1, deleted: false, chainId: chainId);
        var response = await client.Policies.List(request);
        if (response.Data.Count == 0)
        {
            throw new Exception("Policy needs to be created");
        }
        return response.Data[0].Id;
    }

    public static async Task<string> getFirstContractId(this OpenfortClient client, int chainId)
    {
        var request = new ContractListRequest(1, deleted: false, chainId: chainId);
        var response = await client.Contracts.List(request);
        if (response.Data.Count == 0)
        {
            throw new Exception("Contract needs to be created");
        }
        return response.Data[0].Id;
    }

    public static async Task<string> createContract(this OpenfortClient client, int chainId, string address)
    {
        var request = new CreateContractRequest("test", chainId, address);
        var response = await client.Contracts.Create(request);
        return response.Id;
    }

    public static async Task<string> createPolicy(this OpenfortClient client, int chainId, string contractId)
    {
        var policyStrategy = new PolicyStrategyRequest(SponsorSchema.PayForUser);
        var request = new CreatePolicyRequest("test", chainId, policyStrategy);
        var response = await client.Policies.Create(request);
        var createPolicyRuleRequest = new CreatePolicyRuleRequest(PolicyRuleType.ContractFunctions, contract: contractId, functionName: "mint(address)", policy: response.Id);
        await client.PolicyRules.Create(createPolicyRuleRequest);
        return response.Id;
    }
}
