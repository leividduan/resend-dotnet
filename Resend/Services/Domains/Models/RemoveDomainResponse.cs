using System.Text.Json.Serialization;

namespace Resend.Services.Domains.Models;

public class RemoveDomainResponse : AbstractDomainAction
{
	/// <summary>
	/// A boolean flag indicating whether the domain was successfully deleted.
	/// </summary>
	[JsonPropertyName("deleted")]
	public bool Deleted { get; private set; }

	/// <summary>
	/// Default constructor for creating an empty RemoveDomainResponse object.
	/// </summary>
	public RemoveDomainResponse()
	{
	}

	/// <summary>
	/// Constructor to create a RemoveDomainResponse object with the provided attributes.
	/// </summary>
	/// <param name="id">The object type of the response.</param>
	/// <param name="obj">The unique identifier associated with the domain.</param>
	/// <param name="deleted">A boolean flag indicating whether the domain was successfully deleted.</param>
	public RemoveDomainResponse(string id, string obj, bool deleted) : base(id, obj)
	{
		Deleted = deleted;
	}
}
