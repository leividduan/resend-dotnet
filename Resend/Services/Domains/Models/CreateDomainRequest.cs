using System.Text.Json.Serialization;

namespace Resend.Services.Domains.Models;

/// <summary>
/// Represents a request to create a domain.
/// </summary>
public class CreateDomainRequest
{
	/// <summary>
	/// The name of the domain.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; private set; }

	/// <summary>
	/// The region of the domain.
	/// </summary>
	[JsonPropertyName("Region")]
	public string Region { get; private set; }

	/// <summary>
	/// Constructs a CreateDomainRequest object.
	/// </summary>
	/// <param name="name">The name of the domain.</param>
	/// <param name="region">The region of the domain.</param>
	public CreateDomainRequest(string name, string region)
	{
		Name = name;
		Region = region;
	}
}
