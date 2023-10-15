using RestSharp;

namespace Resend.Core.Net.Implementation;

public class ResendHttpClient : IHttpClient
{
	/// <summary>
	/// The base URL for the API.
	/// </summary>
	private static string BASE_API = "https://api.resend.com";

	/// <summary>
	/// The version of the Resend Dotnet SDK.
	/// </summary>
	private static string VERSION = Environment.Version.ToString();

	/// <summary>
	/// The User-Agent header value for HTTP requests.
	/// </summary>
	private static string USER_AGENT = $"resend-dotnet/{VERSION}";

	/// <summary>
	/// The RestClient instance for handling HTTP requests.
	/// </summary>
	private RestClient _restClient;

	/// <summary>
	/// Constructs an instance of the HttpClient with the provided API key.
	/// </summary>
	public ResendHttpClient()
	{
		_restClient = new RestClient(BASE_API);
	}

	/// <summary>
	/// Performs an HTTP request with the specified path, HTTP method, and payload.
	/// </summary>
	/// <param name="path">The path or endpoint of the request.</param>
	/// <param name="apiKey">The API Key used to authenticate the request.</param>
	/// <param name="method">The HTTP method (GET, POST, PUT, DELETE, etc.).</param>
	/// <param name="payload">The payload or data to send with the request.</param>
	/// <param name="contentType">The content type of the request.</param>
	/// <returns>An AbstractHttpResponse representing the response from the server.</returns>
	public AbstractHttpResponse Perform(string path, string apiKey, Method method, string? payload,
		ContentType? contentType)
	{
		var request = new RestRequest(path, method);
		if (!string.IsNullOrEmpty(payload))
			request.AddBody(payload, contentType);

		request
			.AddHeader("Accept", "application/json")
			.AddHeader("User-Agent", USER_AGENT)
			.AddHeader("Authorization", $"Bearer {apiKey}");

		var response = _restClient.Execute(request);
		return new AbstractHttpResponse((int)response.StatusCode, response.Content,
			response.IsSuccessful);
	}
}
