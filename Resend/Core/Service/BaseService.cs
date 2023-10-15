using Resend.Core.Net;
using Resend.Core.Net.Implementation;

namespace Resend.Core.Service;

/// <summary>
/// An abstract base class for service implementations, providing common functionality such as HTTP client, authentication provider, and mapper initialization.
/// </summary>
public abstract class BaseService
{
	/// <summary>
	/// Apikey used for authenticating requests.
	/// </summary>
	protected string ApiKey { get; private set; }

	/// <summary>
	/// HTTP client for making HTTP requests.
	/// </summary>
	protected IHttpClient HttpClient { get; private set; }

	/// <summary>
	/// Constructs a BaseService instance with the specified authentication provider, default HTTP client, and mapper.
	/// </summary>
	/// <param name="apiKey"></param>
	/// <param name="httpClient"></param>
	protected BaseService(string apiKey)
	{
		ApiKey = apiKey;
		HttpClient = new ResendHttpClient();
	}
}
