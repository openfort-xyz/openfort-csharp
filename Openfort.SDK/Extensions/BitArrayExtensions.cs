namespace Openfort.SDK.Extensions
{
	public static class BitArrayExtensions
    {
        public static string ToHex(this byte[] value)
        {
			return BitConverter.ToString(value).Replace("-", string.Empty); ;
        }
	}
}

