namespace Openfort.SDK.Model
{
	public class UpdatePlayerRequest: PlayerUpdateRequest
    {
		public UpdatePlayerRequest(string id, string name = null, string description = null, Dictionary<string, PlayerMetadataValue> metadata = default(Dictionary<string, PlayerMetadataValue>)) : base(name, description, metadata)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

