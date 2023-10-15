using System.Text.Json.Serialization;

namespace Resend.Services.ApiKeys.Model;

/// <summary>
/// Represents a request to create an api key.
/// </summary>
public class CreateApiKeyRequest
{
	/// <summary>
	/// The name of the Api Key.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; private set; }

	/// <summary>
	/// The permission of the Api Key.
	/// </summary>
	[JsonPropertyName("permission")]
	public string Permission { get; private set; }

	/// <summary>
	/// The domain id of the Api Key.
	/// </summary>
	[JsonPropertyName("domain_id")]
	public string DomainId { get; private set; }

	/// <summary>
	/// Constructs an API Key object using the provided builder.
	/// </summary>
	/// <param name="name">The name of the Api Key.</param>
	/// <param name="permission">The permission of the Api Key.</param>
	/// <param name="domainId">The domain id of the Api Key.</param>
	public CreateApiKeyRequest(string name, string permission, string domainId)
	{
		Name = name;
		Permission = permission;
		DomainId = domainId;
	}
}
