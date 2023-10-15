using System.Text.Json.Serialization;

namespace Resend.Services.ApiKeys.Model;

/// <summary>
/// Represents an API key item.
/// </summary>
public class ApiKeyItem
{
	/// <summary>
	/// Get the ID of the API key item.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; private set; }

	/// <summary>
	/// Get the name of the API key item.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; private set; }

	/// <summary>
	/// Get the creation timestamp of the API key item
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; private set; }

	/// <summary>
	/// Default constructor. Creates an instance of ApiKeyItem with default values.
	/// </summary>
	public ApiKeyItem()
	{
	}

	/// <summary>
	/// Creates an instance of ApiKeyItem with the specified attributes.
	/// </summary>
	/// <param name="id">The ID of the API key item.</param>
	/// <param name="name">The name of the API key item.</param>
	/// <param name="createdAt">The creation timestamp of the API key item</param>
	public ApiKeyItem(string id, string name, DateTimeOffset createdAt)
	{
		Id = id;
		Name = name;
		CreatedAt = createdAt;
	}
}
