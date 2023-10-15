namespace Resend.Services.Domains.Models;

/// <summary>
/// Represents a response object for a domain verification operation. This class extends the AbstractDomainAction class and is used to indicate the result of the verification.
/// </summary>
public class VerifyDomainResponse : AbstractDomainAction
{
	/// <summary>
	/// Default constructor for creating an empty VerifyDomainResponse object.
	/// </summary>
	public VerifyDomainResponse()
	{

	}

	/// <summary>
	/// Constructs a VerifyDomainResponse object with the provided object type and identifier.
	/// </summary>
	/// <param name="id">The object type of the response.</param>
	/// <param name="obj">The unique identifier associated with the verified domain.</param>
	public VerifyDomainResponse(string id, string obj) : base(id, obj)
	{
	}
}
