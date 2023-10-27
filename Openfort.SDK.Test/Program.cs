using System.Diagnostics;
using Openfort.SDK;
using Openfort.SDK.Model;

var client = new OpenfortClient("sk_test_c4346cc1-15b2-5036-9052-561a1ac71870");

//var body = """{"data":{"id":"tin_dcdd8b07-91bb-4016-8b11-16db72fdc9bc","object":"transactionIntent","createdAt":1693995911,"userOperationHash":"0x2e13d4079a425dea2bc5059b2d18c9964beef61ca9e9f91702500bef8430fc0d","userOperation":{"sender":"0x1BbE81D16496F1D08aeCDf0d40EF7c00265892BB","nonce":0,"initCode":"0xda62c30850daa97d6a14e0f95483d6d6e0e00e8c86c8790b000000000000000000000000181cf2fb56378b45b289dd3e97b37e078f9ff919e27be8ffab8879c5087f5f11449e9a0c2ef87f042b1d4a1d5709a383e9b2a4ee","callData":"0x47e1da2a000000000000000000000000000000000000000000000000000000000000006000000000000000000000000000000000000000000000000000000000000000c00000000000000000000000000000000000000000000000000000000000000120000000000000000000000000000000000000000000000000000000000000000200000000000000000000000038090d1636069c0ff1af6bc1737fb996b7f63ac000000000000000000000000038090d1636069c0ff1af6bc1737fb996b7f63ac00000000000000000000000000000000000000000000000000000000000000002000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000000000000000000000000000000000000000000000000000000000004000000000000000000000000000000000000000000000000000000000000000a000000000000000000000000000000000000000000000000000000000000000246a6278420000000000000000000000001bbe81d16496f1d08aecdf0d40ef7c00265892bb0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000246a6278420000000000000000000000001bbe81d16496f1d08aecdf0d40ef7c00265892bb00000000000000000000000000000000000000000000000000000000","callGasLimit":{"type":"BigNumber","hex":"0x0a9246"},"verificationGasLimit":{"type":"BigNumber","hex":"0x0b7c56"},"preVerificationGas":{"type":"BigNumber","hex":"0xc3a0"},"maxFeePerGas":{"type":"BigNumber","hex":"0x59682f30"},"maxPriorityFeePerGas":{"type":"BigNumber","hex":"0x59682f00"},"paymasterAndData":"0xf26acbbf356fb561b64b29aae887ffdb1dd1980200000000000000000000000000000000000000000000000000000000deadbeef0000000000000000000000000000000000000000000000000000000000001234000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001cf2eea161dacfff00349893c74add274d9666f526ceb05ee138a19c2eb19e407300b8b616d7ad0f4d488d934e534759d909fcc7a3bd071426630ee49cd7c9b11c","signature":"0xe6155d69e7e13ae0fa6e2d2fc56fdf3216f875f14387bbd3a66cab6b1450be1c55f26d202808e503c083b60569519f77b700d4c548fd0823d4bc0c9ee00136e51c"},"chainId":80001,"updatedAt":1697812030,"response":{"createdAt":1693995917,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","userOpHash":"0x2e13d4079a425dea2bc5059b2d18c9964beef61ca9e9f91702500bef8430fc0d","status":1,"blockNumber":39815394,"gasUsed":460727,"logs":[{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0xDA62C30850daA97d6A14e0F95483D6D6E0e00E8C","topics":["0xac631f3001b55ea1509cf3d7e74898f85392a61a76e8149181ae1259622dabc8","0x0000000000000000000000001bbe81d16496f1d08aecdf0d40ef7c00265892bb","0x000000000000000000000000181cf2fb56378b45b289dd3e97b37e078f9ff919"],"data":"0x","logIndex":128,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x1BbE81D16496F1D08aeCDf0d40EF7c00265892BB","topics":["0xbc7cd75a20ee27fd9adebab32041f755214dbc6bffa90cc0225b39da2e5c2d3b","0x000000000000000000000000e61bb6c2d371f03745f9eb479c6ef23be497619b"],"data":"0x","logIndex":129,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x1BbE81D16496F1D08aeCDf0d40EF7c00265892BB","topics":["0x9efc8bb238b1965522b3e784290f41e0229e21a34f499fd2f71b64463283a416"],"data":"0x00000000000000000000000000000000000000000000000000000000000000000000000000000000000000005ff137d4b0fdcd49dca30c7cf57e578a026d2789","logIndex":130,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x1BbE81D16496F1D08aeCDf0d40EF7c00265892BB","topics":["0x8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0","0x0000000000000000000000000000000000000000000000000000000000000000","0x000000000000000000000000181cf2fb56378b45b289dd3e97b37e078f9ff919"],"data":"0x","logIndex":131,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x1BbE81D16496F1D08aeCDf0d40EF7c00265892BB","topics":["0x7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb3847402498"],"data":"0x0000000000000000000000000000000000000000000000000000000000000001","logIndex":132,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x5FF137D4b0FDCD49DcA30c7CF57E578a026d2789","topics":["0xd51a9c61267aa6196961883ecf5ff2da6619c37dac0fa92122513fb32c032d2d","0x2e13d4079a425dea2bc5059b2d18c9964beef61ca9e9f91702500bef8430fc0d","0x0000000000000000000000001bbe81d16496f1d08aecdf0d40ef7c00265892bb"],"data":"0x000000000000000000000000da62c30850daa97d6a14e0f95483d6d6e0e00e8c000000000000000000000000f26acbbf356fb561b64b29aae887ffdb1dd19802","logIndex":133,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x5FF137D4b0FDCD49DcA30c7CF57E578a026d2789","topics":["0xbb47ee3e183a558b1a2ff0874b079f3fc5478b7454eacf2bfc5af2ff5878f972"],"data":"0x","logIndex":134,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x38090d1636069c0ff1Af6bc1737Fb996B7f63AC0","topics":["0xddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef","0x0000000000000000000000000000000000000000000000000000000000000000","0x0000000000000000000000001bbe81d16496f1d08aecdf0d40ef7c00265892bb","0x0000000000000000000000000000000000000000000000000000000000000d59"],"data":"0x","logIndex":135,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x38090d1636069c0ff1Af6bc1737Fb996B7f63AC0","topics":["0xddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef","0x0000000000000000000000000000000000000000000000000000000000000000","0x0000000000000000000000001bbe81d16496f1d08aecdf0d40ef7c00265892bb","0x0000000000000000000000000000000000000000000000000000000000000d5a"],"data":"0x","logIndex":136,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x5FF137D4b0FDCD49DcA30c7CF57E578a026d2789","topics":["0x49628fd1471006c1482da88028e9ce4dbb080b815c9b0344d39e5a8e6ec1419f","0x2e13d4079a425dea2bc5059b2d18c9964beef61ca9e9f91702500bef8430fc0d","0x0000000000000000000000001bbe81d16496f1d08aecdf0d40ef7c00265892bb","0x000000000000000000000000f26acbbf356fb561b64b29aae887ffdb1dd19802"],"data":"0x00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000271c779f49dd2000000000000000000000000000000000000000000000000000000000006ffcd","logIndex":137,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x0000000000000000000000000000000000001010","topics":["0xe6497e3ee548a3372136af2fcb0696db31fc6cf20260707645068bd3fe97f3c4","0x0000000000000000000000000000000000000000000000000000000000001010","0x0000000000000000000000005ff137d4b0fdcd49dca30c7cf57e578a026d2789","0x0000000000000000000000004337da24bf93f81870da9deac153b6b36f6120c6"],"data":"0x000000000000000000000000000000000000000000000000000271c779f49dd20000000000000000000000000000000000000000000000c006084dbd1d1d546e000000000000000000000000000000000000000000000000537092e3e0a8e2170000000000000000000000000000000000000000000000c00605dbf5a328b69c000000000000000000000000000000000000000000000000537304ab5a9d7fe9","logIndex":138,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"},{"removed":false,"transactionIndex":26,"blockNumber":39815394,"transactionHash":"0x6d2d28fea8fd0c51dc51287fbf94ad31049441aeabbe39ca98ee05cd20eb6dc1","address":"0x0000000000000000000000000000000000001010","topics":["0x4dfe1bbbcf077ddc3e01291eea2d5c70c2b422b415d95645b9adcfd678cb1d63","0x0000000000000000000000000000000000000000000000000000000000001010","0x0000000000000000000000004337da24bf93f81870da9deac153b6b36f6120c6","0x000000000000000000000000be188d6641e8b680743a4815dfa0f6208038960f"],"data":"0x0000000000000000000000000000000000000000000000000003fba2fc652ee8000000000000000000000000000000000000000000000000538fb4e3437e6f4f0000000000000000000000000000000000000000000034223dd989651f735dc4000000000000000000000000000000000000000000000000538bb940471940670000000000000000000000000000000000000000000034223ddd85081bd88cac","logIndex":139,"blockHash":"0x459319a9847d16fd89889ec7e5b8f6dc099f043ab26f5e4cf1c55add96e7a4d7"}],"to":"0x5FF137D4b0FDCD49DcA30c7CF57E578a026d2789"},"interactions":[{"functionName":"mint(address)","functionArgs":["\"0x1BbE81D16496F1D08aeCDf0d40EF7c00265892BB\""],"contract":"0x38090d1636069c0ff1af6bc1737fb996b7f63ac0"},{"functionName":"mint(address)","functionArgs":["\"0x1BbE81D16496F1D08aeCDf0d40EF7c00265892BB\""],"contract":"0x38090d1636069c0ff1af6bc1737fb996b7f63ac0"}],"account":{"id":"acc_03881b5e-f39d-4020-946c-fcf095f7e6fb"},"policy":{"id":"pol_72bcd7e7-10f7-4935-a0c0-19235e7a1ea6"},"player":{"id":"pla_1b8ee4a2-8c5e-4d9f-b1b7-cd205cbb3c0b"}},"date":1697812090}""";
////var body = "a";
//var secret = "973d7e30b9adf4336602e89876c53700e390ef26821eaa5711c19c5c77a3c5dc";

//var transaction = client.ConstructWebhookEvent(body, secret);
//Console.Write(transaction.Data.Id);

var playerId = await client.createPlayer();
var chainId = 80001;
var contractId = await client.createContract(chainId, "0x38090d1636069c0ff1af6bc1737fb996b7f63ac0");
var policyId = await client.createPolicy(chainId, contractId);

var interactions = new List<Interaction>{
    new Interaction(contract: contractId, functionName: "mint", functionArgs: new List<object> { playerId }),
    new Interaction(contract: contractId, functionName: "mint", functionArgs: new List<object> { playerId }),
};

var playerCreateSessionRequest = new PlayerCreateSessionRequest(
    playerId,
    "0xDC91aDF855306A44F4041625328abEAB3887b3b8",
    chainId,
    0,
    (int)DateTime.UtcNow.AddYears(1).Subtract(new DateTime(1970, 1, 1)).TotalSeconds
);
var response = await client.Players.CreateAccount(new PlayerCreateAccountRequest(playerId, chainId, "0xDC91aDF855306A44F4041625328abEAB3887b3b8"));


//var createSessionResponse = await client.Players.CreateSession(playerCreateSessionRequest);
//Console.Write(createSessionResponse.ToJson());

var transactionIntentRequest = new CreateTransactionIntentRequest(
    playerId,
    chainId,
    policyId,
    interactions: interactions
);

var transactionIntentResponse = await client.TransactionIntents.Create(transactionIntentRequest);
Console.Write(transactionIntentResponse.ToJson());

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
