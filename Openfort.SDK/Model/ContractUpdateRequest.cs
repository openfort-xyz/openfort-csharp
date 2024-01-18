using System;
namespace Openfort.SDK.Model
{
	public class ContractUpdateRequest : UpdateContractRequest
	{
		public ContractUpdateRequest(string id, string? name = default, int chainId = default(int), bool deleted = default(bool), string? address = default, List<Abi> abi = default(List<Abi>)) : base(name, chainId, deleted, address, abi)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

