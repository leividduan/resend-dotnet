using System.Text.Json.Serialization;
using Resend.Services.Domains.Dto;

namespace Resend.Services.Domains.Models;

/// <summary>
/// Represents a response object for listing domains. This class contains a list of DomainDTO objects and is used to encapsulate the data returned from a list domains operation.
/// </summary>
public class ListDomainsResponse
{
	/// <summary>
	/// The list of DomainDTO objects containing domain data.
	/// </summary>
	[JsonPropertyName("data")]
	public List<DomainDto> Data { get; private set; }

	/// <summary>
	/// Default constructor for creating an empty ListDomainsResponse object.
	/// </summary>
	public ListDomainsResponse()
	{
	}

	/// <summary>
	/// Constructor to create a ListDomainsResponse object with the provided list of DomainDTO objects.
	/// </summary>
	/// <param name="data">The list of DomainDTO objects.</param>
	public ListDomainsResponse(List<DomainDto> data)
	{
		Data = data;
	}
}
