using System.Text.Json.Serialization;

namespace Resend.Services.Domains.Models;

/// <summary>
/// Represents a domain object.
/// </summary>
public class Domain : AbstractDomain
{
	/// <summary>
	/// The object of the domain.
	/// </summary>
	[JsonPropertyName("object")]
	public string Object { get; private set; }

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
	/// Default constructor for creating an Domain instance with uninitialized fields.
	/// </summary>
	public Domain()
	{
	}

	/// <summary>
	/// Constructor to create an immutable Domain instance.
	/// </summary>
	/// <param name="id">The ID of the domain.</param>
	/// <param name="name">The name of the domain.</param>
	/// <param name="createdAt">The creation timestamp of the domain.</param>
	/// <param name="status">The status of the domain.</param>
	/// <param name="region">The region of the domain.</param>
	/// <param name="obj">The type of the object (e.g., "domain").</param>
	/// <param name="records">The list of DNS records associated with the domain.</param>
	/// <param name="dnsProvider">The dnsProvider of the domain.</param>
	public Domain(string id, string name, DateTimeOffset createdAt, string status, string region, string obj, List<Record> records, string dnsProvider)
		: base(id, name, createdAt, status, region)
	{
		Object = obj;
		Records = records;
		DnsProvider = dnsProvider;
	}
}
