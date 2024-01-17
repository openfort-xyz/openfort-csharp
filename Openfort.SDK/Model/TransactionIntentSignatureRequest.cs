namespace Openfort.SDK.Model
{
    public class TransactionIntentSignatureRequest : SignatureRequest
    {
        public TransactionIntentSignatureRequest(string id, string signature, bool optimistic = true) : base(signature, optimistic)
        {
            Id = id;
        }

        public string Id { get; set; }
    }
}

