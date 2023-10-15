using System.Text.Json.Serialization;

namespace Resend.Services.Domains.Models;

/// <summary>
/// Represents a response object for creating a domain. This class extends the AbstractDomain class and includes additional attributes specific to a create domain response.
/// </summary>
public class CreateDomainResponse : AbstractDomain
{
	/// <summary>
	/// The records of the domain.
	/// </summary>
	[JsonPropertyName("records")]
	public List<Record> Records { get; private set; }

	/// <summary>
	/// The DNS provider of the domain.
	/// </summary>
	[JsonPropertyName("dnsProvider")]
	public string DnsProvider { get; private set; }

	/// <summary>
	/// Default constructor for creating an empty CreateDomainResponse object.
	/// </summary>
	public CreateDomainResponse()
	{
	}

	/// <summary>
	/// Constructor to create a CreateDomainResponse object with the provided attributes.
	/// </summary>
	/// <param name="id">The ID of the domain.</param>
	/// <param name="name">The name of the domain.</param>
	/// <param name="createdAt">The creation timestamp of the domain.</param>
	/// <param name="status">The status of the domain.</param>
	/// <param name="region">The region of the domain.</param>
	/// <param name="records">The list of DNS records associated with the domain.</param>
	/// <param name="dnsProvider">The dnsProvider of the domain.</param>
	public CreateDomainResponse(string id, string name, DateTimeOffset createdAt, string status, string region, List<Record> records, string dnsProvider)
		: base(id, name, createdAt, status, region)
	{
		Records = records;
		DnsProvider = dnsProvider;
	}
}
