namespace Openfort.SDK.Model
{
	public class AccountSignPayloadRequest: SignPayloadRequest
    {
		public AccountSignPayloadRequest(string id, DomainData domain, Dictionary<string, List<TypedDataField>> types, string primaryType, Dictionary<string, Object> value, string hash): base(domain, types, primaryType, value, hash)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

