namespace Resend.Core.Net;

/// <summary>
/// Represents an HTTP response containing the response code, body, and success status.
/// </summary>
/// <typeparam name="T">The type of the response body.</typeparam>
public class AbstractHttpResponse
{
	/// <summary>
	/// The HTTP response code.
	/// </summary>
	public int Code { get; set; }

	/// <summary>
	/// The response body.
	/// </summary>
	public string? Body { get; set; }

	/// <summary>
	/// Indicates whether the HTTP request was successful.
	/// </summary>
	public bool IsSuccessful { get; set; }

	/// <summary>
	/// Constructs an instance of AbstractHttpResponse with the provided values.
	/// </summary>
	/// <param name="code">The HTTP response code.</param>
	/// <param name="body">The response body.</param>
	/// <param name="isSuccessful">Whether the HTTP request was successful.</param>
	public AbstractHttpResponse(int code, string? body, bool isSuccessful)
	{
		Code = code;
		Body = body;
		IsSuccessful = isSuccessful;
	}
}
