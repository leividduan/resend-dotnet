using System.Text.Json;
using Resend.Core.Exception;
using Resend.Core.Service;
using Resend.Services.Emails.Model;
using Resend.Services.Interfaces;
using RestSharp;

namespace Resend.Services.Emails;

/// <summary>
/// Represents the Resend Emails module.
/// </summary>
public class Emails : BaseService, IEmails
{
	/// <summary>
	/// Constructs an instance of the Emails class.
	/// </summary>
	/// <param name="apiKey">The apiKey used for authentication.</param>
	public Emails(string apiKey) : base(apiKey)
	{
	}

	/// <summary>
	/// Sends an email based on the provided email request.
	/// </summary>
	/// <param name="sendEmailRequest">The request containing email details.</param>
	/// <returns>The response indicating the status of the email sending.</returns>
	/// <exception cref="ResendException">If an error occurs while sending the email.</exception>
	public SendEmailResponse Send(SendEmailRequest sendEmailRequest)
	{
		var payload = JsonSerializer.Serialize(sendEmailRequest);

		var response = HttpClient.Perform("/emails", ApiKey, Method.Post, payload, ContentType.Json);

		if (!response.IsSuccessful)
			throw new ResendException($"Failed to send email: {response.Code} {response.Body}");

		var sendEmailResponse = JsonSerializer.Deserialize<SendEmailResponse>(response.Body!);

		return sendEmailResponse!;
	}

	public Email Get(string emailId)
	{
		var response = HttpClient.Perform($"/emails/{emailId}", ApiKey, Method.Get, null, ContentType.Json);

		if (!response.IsSuccessful)
			throw new ResendException($"Failed to retrieve email: {response.Code} {response.Body}");

		var email = JsonSerializer.Deserialize<Email>(response.Body!);

		return email!;
	}
}
