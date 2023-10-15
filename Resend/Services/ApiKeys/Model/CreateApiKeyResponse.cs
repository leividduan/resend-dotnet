using System.Text.Json.Serialization;

namespace Resend.Services.ApiKeys.Model;

/// <summary>
/// Represents the API key response.
/// </summary>
public class CreateApiKeyResponse
{
	/// <summary>
	/// The ID of the API key.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; private set; }

	/// <summary>
	/// The token of the API key.
	/// </summary>
	[JsonPropertyName("token")]
	public string Token { get; private set; }

	/// <summary>
	/// Default constructor. Creates an instance of CreateApiKeyResponse with default values for id and token.
	/// </summary>
	public CreateApiKeyResponse()
	{
	}

	/// <summary>
	/// Creates an instance of CreateApiKeyResponse with the specified id and token.
	/// </summary>
	/// <param name="id">The ID of the API key.</param>
	/// <param name="token">The token of the API key.</param>
	public CreateApiKeyResponse(string id, string token)
	{
		Id = id;
		Token = token;
	}
}
