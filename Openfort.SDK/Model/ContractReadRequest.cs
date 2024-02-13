namespace Openfort.SDK.Model
{
	public class ContractReadRequest
	{
		public ContractReadRequest(string id, string functionName, List<Object>? functionArgs = default(List<Object>))
		{
			Id = id;
			FunctionName = functionName;
			FunctionArgs = functionArgs;
		}
		public string Id { get; set; }
		public string FunctionName { get; set; }
		public List<Object> FunctionArgs { get; set; }

	}
}

