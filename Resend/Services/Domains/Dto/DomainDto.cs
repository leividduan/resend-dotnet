using Resend.Services.Domains.Models;

namespace Resend.Services.Domains.Dto;

/// <summary>
/// A Data Transfer Object (DTO) representing a domain. This class extends the AbstractDomain class and is used for transferring domain-related data.
/// </summary>
public class DomainDto : AbstractDomain
{
	/// <summary>
	/// Default constructor for creating an empty DomainDTO object.
	/// </summary>
	public DomainDto()
	{
	}

	/// <summary>
	/// Constructor to create a DomainDTO object with the provided attributes.
	/// </summary>
	/// <param name="id">The ID of the domain.</param>
	/// <param name="name">The name of the domain.</param>
	/// <param name="createdAt">The creation timestamp of the domain.</param>
	/// <param name="status">The status of the domain.</param>
	/// <param name="region">The region of the domain.</param>
	public DomainDto(string id, string name, DateTimeOffset createdAt, string status, string region)
		: base(id, name, createdAt, status, region)
	{
	}
}
