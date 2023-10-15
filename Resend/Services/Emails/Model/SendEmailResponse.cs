using System.Text.Json.Serialization;

namespace Resend.Services.Emails.Model;

/// <summary>
/// Represents a response after sending an email.
/// </summary>
public class SendEmailResponse
{
	/// <summary>
	/// The unique identifier associated with the email.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Constructs a new instance of {@code SendEmailResponse}.
	/// </summary>
	public SendEmailResponse()
	{
	}

	/// <summary>
	/// Constructs a SendEmailResponse with the provided ID.
	/// </summary>
	/// <param name="id">The ID associated with the sent email.</param>
	public SendEmailResponse(string id)
	{
		Id = id;
	}
}
