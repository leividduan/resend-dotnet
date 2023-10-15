using System.Text.Json.Serialization;

namespace Resend.Services.ApiKeys.Model;

/// <summary>
/// Represents a list API keys response.
/// </summary>
public class ListApiKeysResponse
{
	/// <summary>
	/// Gets the list of API key items.
	/// </summary>
	[JsonPropertyName("data")]
	public List<ApiKeyItem> Data { get; private set; }

	/// <summary>
	/// Default constructor. Creates an instance of ListApiKeysResponse with an empty data list.
	/// </summary>
	public ListApiKeysResponse()
	{
	}

	/// <summary>
	/// Creates an instance of ListApiKeyResponse with the specified data.
	/// </summary>
	/// <param name="data">The list of API key items.</param>
	public ListApiKeysResponse(List<ApiKeyItem> data)
	{
		Data = data;
	}
}
