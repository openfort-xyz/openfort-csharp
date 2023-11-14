namespace Openfort.SDK.Model
{
	public class Web3ActionSubmit
    {
		public Web3ActionSubmit(string id, string web3Action, SubmitWeb3ActionRequest submitWeb3ActionRequest)
		{
			Id = id;
            Web3Action = web3Action;
            SubmitWeb3ActionRequest = submitWeb3ActionRequest;
		}

		public string Id { get; set; }
        public string Web3Action { get; set; }
        public SubmitWeb3ActionRequest SubmitWeb3ActionRequest { get; set; }
	}
}
