using System.Text.Json;
using Resend.Core.Exception;
using Resend.Core.Service;
using Resend.Services.Domains.Models;
using Resend.Services.Interfaces;
using RestSharp;

namespace Resend.Services.Domains;

/// <summary>
/// Represents the Resend Emails module.
/// </summary>
public class Domains : BaseService, IDomains
{
	/// <summary>
	/// Constructs an instance of the code Domains class.
	/// </summary>
	/// <param name="apiKey">The apiKey used for authentication.</param>
	public Domains(string apiKey) : base(apiKey)
	{
	}

	/// <summary>
	/// Creates a domain based on the provided CreateDomainRequest and returns a CreateDomainResponse.
	/// </summary>
	/// <param name="createDomainRequest">The request object containing the domain creation details.</param>
	/// <returns>A CreateDomainResponse representing the result of the domain creation operation.</returns>
	/// <exception cref="ResendException">If an error occurs during the domain creation process.</exception>
	public CreateDomainResponse Create(CreateDomainRequest createDomainRequest)
	{
		var payload = JsonSerializer.Serialize(createDomainRequest);

		var response = HttpClient.Perform("/domains", ApiKey, Method.Post, payload, ContentType.Json);

		if (!response.IsSuccessful)
			throw new ResendException($"Failed to create domain: {response.Code} {response.Body}");

		var createDomainResponse = JsonSerializer.Deserialize<CreateDomainResponse>(response.Body!);

		return createDomainResponse!;
	}

	/// <summary>
	/// Retrieves a domain based on the provided domain ID and returns a Domain object.
	/// </summary>
	/// <param name="domainId">The unique identifier of the domain to retrieve.</param>
	/// <returns>A Domain object representing the retrieved domain.</returns>
	/// <exception cref="ResendException">If an error occurs during the domain retrieval process.</exception>
	public Domain Get(string domainId)
	{
		try
		{
			var response = HttpClient.Perform($"/domains/{domainId}", ApiKey, Method.Get, null, ContentType.Json);

			if (!response.IsSuccessful)
				throw new ResendException($"Failed to retrieve domain: {response.Code} {response.Body}");

			var domain = JsonSerializer.Deserialize<Domain>(response.Body!);

			return domain!;
		}
		catch (Exception e)
		{
			throw new ResendException($"Error retrieving domain: {e.Message}", e);
		}
	}

	/// <summary>
	/// Verifies a domain based on the provided domain ID and returns a VerifyDomainResponse.
	/// </summary>
	/// <param name="domainId">The unique identifier of the domain to verify.</param>
	/// <returns>A VerifyDomainResponse representing the result of the domain verification operation.</returns>
	/// <exception cref="ResendException">If an error occurs during the domain verification process.</exception>
	public VerifyDomainResponse Verify(string domainId)
	{
		var response = HttpClient.Perform($"/domains/{domainId}/verify", ApiKey, Method.Post, null, ContentType.Json);

		if (!response.IsSuccessful)
			throw new ResendException($"Failed to verify domain: {response.Code} {response.Body}");

		var verifyDomainResponse = JsonSerializer.Deserialize<VerifyDomainResponse>(response.Body!);

		return verifyDomainResponse!;
	}

	/// <summary>
	/// Retrieves a list of domains and returns a ListDomainsResponse.
	/// </summary>
	/// <returns>A ListDomainsResponse containing the list of domains.</returns>
	/// <exception cref="ResendException">If an error occurs during the domain list retrieval process.</exception>
	public ListDomainsResponse List()
	{
		var response = HttpClient.Perform("/domains", ApiKey, Method.Get, null, ContentType.Json);

		if (!response.IsSuccessful)
			throw new ResendException($"Failed to retrieve domains list: {response.Code} {response.Body}");

		var listDomainsResponse = JsonSerializer.Deserialize<ListDomainsResponse>(response.Body!);

		return listDomainsResponse!;
	}

	/// <summary>
	/// Deletes a domain based on the provided domain ID and returns a RemoveDomainResponse.
	/// </summary>
	/// <param name="domainId">The unique identifier of the domain to delete.</param>
	/// <returns>A RemoveDomainResponse representing the result of the domain deletion operation.</returns>
	/// <exception cref="ResendException">If an error occurs during the domain deletion process.</exception>
	public RemoveDomainResponse Remove(string domainId)
	{
		var response = HttpClient.Perform($"/domains/{domainId}", ApiKey, Method.Delete, null, ContentType.Json);

		if (!response.IsSuccessful)
			throw new ResendException($"Failed to delete domain: {response.Code} {response.Body}");

		var removeDomainResponse = JsonSerializer.Deserialize<RemoveDomainResponse>(response.Body!);

		return removeDomainResponse!;
	}
}
