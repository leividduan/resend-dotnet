using System.Text.Json;
using Resend.Core.Exception;
using Resend.Core.Service;
using Resend.Services.ApiKeys.Model;
using Resend.Services.Interfaces;
using RestSharp;

namespace Resend.Services.ApiKeys;

/// <summary>
/// Represents the Resend ApiKeys module.
/// </summary>
public class ApiKeys : BaseService, IApiKeys
{
	/// <summary>
	/// Constructs an instance of the ApiKeys class.
	/// </summary>
	/// <param name="apiKey">The apiKey used for authentication.</param>
	public ApiKeys(string apiKey) : base(apiKey)
	{
	}

	/// <summary>
	/// Creates an API key.
	/// </summary>
	/// <param name="createApiKeyRequest">The request the API key details.</param>
	/// <returns>The response indicating the state of the api key.</returns>
	/// <exception cref="ResendException">If an error occurs during the API key creation process.</exception>
	public CreateApiKeyResponse Create(CreateApiKeyRequest createApiKeyRequest)
	{
		var payload = JsonSerializer.Serialize(createApiKeyRequest);

		var response = HttpClient.Perform("/api-keys", ApiKey, Method.Post, payload, ContentType.Json);

		if (!response.IsSuccessful)
			throw new ResendException($"Failed to create api key: {response.Code} {response.Body}");

		var createApiKeyResponseResponse = JsonSerializer.Deserialize<CreateApiKeyResponse>(response.Body!);

		return createApiKeyResponseResponse!;
	}

	/// <summary>
	/// Retrieves a list of api keys and returns a ListApiKeysResponse.
	/// </summary>
	/// <returns>A ListApiKeysResponse containing the list of api keys.</returns>
	/// <exception cref="ResendException">If an error occurs during the api keys list retrieval process.</exception>
	public ListApiKeysResponse List()
	{
		var response = HttpClient.Perform("/api-keys", ApiKey, Method.Get, null, ContentType.Json);

		if (!response.IsSuccessful)
			throw new ResendException($"Failed to create api key: {response.Code} {response.Body}");

		var listApiKeysResponse = JsonSerializer.Deserialize<ListApiKeysResponse>(response.Body!);

		return listApiKeysResponse!;
	}

	/// <summary>
	/// Deletes an api key based on the provided api key ID and returns a boolean response.
	/// </summary>
	/// <param name="apiKeyId">The unique identifier of the api key to delete.</param>
	/// <returns>A boolean representing the result of the api key deletion operation.</returns>
	/// <exception cref="ResendException">If an error occurs during the api key deletion process.</exception>
	public bool Remove(string apiKeyId)
	{
		var response = HttpClient.Perform($"/api-keys/{apiKeyId}", ApiKey, Method.Delete, null, null);

		if (!response.IsSuccessful)
			throw new ResendException($"Failed to create api key: {response.Code} {response.Body}");

		return true;
	}
}
