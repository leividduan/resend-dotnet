using System.Text.Json.Serialization;

namespace Resend.Services.Emails.Model;

/// <summary>
/// Represents a tag associated with an email.
/// </summary>
public class Tag
{
	/// <summary>
	/// Get the name of the tag.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; private set; }

	/// <summary>
	/// Get the value of the tag.
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; private set; }

	/// <summary>
	/// Create a new Tag object.
	/// </summary>
	/// <param name="name">The name of the tag.</param>
	/// <param name="value">The value of the tag.</param>
	public Tag(string name, string value)
	{
		Name = name;
		Value = value;
	}
}
