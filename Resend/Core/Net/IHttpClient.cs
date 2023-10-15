using RestSharp;

namespace Resend.Core.Net;

/// <summary>
/// An interface representing an HTTP client for performing HTTP requests and receiving responses.
/// </summary>
/// <typeparam name="T">The type of response data expected.</typeparam>
public interface IHttpClient
{
	/// <summary>
	/// Perform an HTTP request with the specified path, method, and payload.
	/// </summary>
	/// <param name="path">The path or endpoint of the request.</param>
	/// <param name="apiKey">The API Key used to authenticate the request.</param>
	/// <param name="method">The HTTP method (GET, POST, PUT, DELETE, etc.).</param>
	/// <param name="payload">The payload or data to send with the request.</param>
	/// <param name="contentType">The content type of the request.</param>
	/// <returns>An AbstractHttpResponse representing the response from the server.</returns>
	// AbstractHttpResponse<T> Perform(string path, string apiKey, HttpMethod method, string payload, MediaType mediaType);
	AbstractHttpResponse Perform(string path, string apiKey, Method method, string? payload, ContentType? contentType);
}
