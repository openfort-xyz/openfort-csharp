namespace Openfort.SDK.Model
{
	public class SessionSignatureRequest: SignatureRequest
    {
		public SessionSignatureRequest(string id, string signature, bool optimistic = true): base(signature, optimistic)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

