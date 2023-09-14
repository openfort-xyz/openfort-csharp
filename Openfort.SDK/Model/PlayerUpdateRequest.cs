namespace Openfort.SDK.Model
{
	public class PlayerUpdateRequest: PlayerRequest
    {
		public PlayerUpdateRequest(string id, string name = null, string description = null): base(name, description)
		{
			Id = id;
		}

		public string Id { get; set; }
	}
}

