using System.Text.Json.Serialization;

namespace Resend.Services.Domains.Models;

/// <summary>
/// An abstract class representing a domain entity with common attributes.
/// </summary>
public abstract class AbstractDomain
{
	/// <summary>
	/// Get the ID of the domain.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; private set; }

	/// <summary>
	/// Get the name of the domain.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; private set; }

	/// <summary>
	/// Get the creation timestamp of the domain.
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; private set; }

	/// <summary>
	/// Get the status of the domain.
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; private set; }

	/// <summary>
	/// Get the region of the domain.
	/// </summary>
	[JsonPropertyName("region")]
	public string Region { get; private set; }

	/// <summary>
	/// Default constructor for creating an AbstractDomain instance with uninitialized fields.
	/// </summary>
	protected AbstractDomain()
	{
	}

	/// <summary>
	/// Constructor to create an immutable AbstractDomain instance with the provided attributes.
	/// </summary>
	/// <param name="id"></param>
	/// <param name="name"></param>
	/// <param name="createdAt"></param>
	/// <param name="status"></param>
	/// <param name="region"></param>
	protected AbstractDomain(string id, string name, DateTimeOffset createdAt, string status, string region)
	{
		Id = id;
		Name = name;
		CreatedAt = createdAt;
		Status = status;
		Region = region;
	}
}
