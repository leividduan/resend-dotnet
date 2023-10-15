using System.Text.Json.Serialization;

namespace Resend.Services.Domains.Models;

/// <summary>
/// Represents a response object for a domain action. This class is typically used to deserialize responses from verification and deletion operation.
/// </summary>
public abstract class AbstractDomainAction
{
	/// <summary>
	/// The unique identifier associated with the verified domain.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; private set; }

	/// <summary>
	/// The object type of the response.
	/// </summary>
	[JsonPropertyName("object")]
	public string Object { get; private set; }

	/// <summary>
	/// Default constructor for creating an empty AbstractDomainAction object.
	/// </summary>
	protected AbstractDomainAction()
	{
	}

	/// <summary>
	/// Constructs a AbstractDomainAction object with the provided object type and identifier.
	/// </summary>
	/// <param name="id">The object type of the response.</param>
	/// <param name="obj">The unique identifier associated with the verified domain.</param>
	protected AbstractDomainAction(string id, string obj)
	{
		Id = id;
		Object = obj;
	}
}
