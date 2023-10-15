using System.Text.Json.Serialization;

namespace Resend.Services.Emails.Model;

/// <summary>
/// Represents an email.
/// </summary>
public class Email
{
	/// <summary>
	/// The id attribute value.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; private set; }

	/// <summary>
	/// The object attribute value.
	/// </summary>
	[JsonPropertyName("object")]
	public string Object { get; private set; }

	/// <summary>
	/// The from attribute value.
	/// </summary>
	[JsonPropertyName("from")]
	public string From { get; private set; }

	/// <summary>
	/// The subject attribute value.
	/// </summary>
	[JsonPropertyName("subject")]
	public string Subject { get; private set; }

	/// <summary>
	/// The html attribute value.
	/// </summary>
	[JsonPropertyName("html")]
	public string Html { get; private set; }

	/// <summary>
	/// The text attribute value.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; private set; }

	/// <summary>
	/// The last_event attribute value.
	/// </summary>
	[JsonPropertyName("last_event")]
	public string LastEvent { get; private set; }

	/// <summary>
	/// The created_at attribute value.
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; private set; }

	/// <summary>
	/// The to attribute value.
	/// </summary>
	[JsonPropertyName("to")]
	public List<string> To { get; private set; }

	/// <summary>
	/// The bcc attribute value.
	/// </summary>
	[JsonPropertyName("bcc")]
	public List<string> Bcc { get; private set; }

	/// <summary>
	/// The cc attribute value.
	/// </summary>
	[JsonPropertyName("cc")]
	public List<string> Cc { get; private set; }

	/// <summary>
	/// The reply_to attribute value.
	/// </summary>
	[JsonPropertyName("reply_to")]
	public List<string> ReplyTo { get; private set; }

	/// <summary>
	/// Default constructor.
	/// </summary>
	public Email()
	{
	}

	/// <summary>
	/// Constructs an Email object with the provided attributes.
	/// </summary>
	/// <param name="id">The id attribute value.</param>
	/// <param name="obj">The object attribute value.</param>
	/// <param name="from"> The from attribute value.</param>
	/// <param name="subject">The subject attribute value.</param>
	/// <param name="html">The html attribute value.</param>
	/// <param name="text">The text attribute value.</param>
	/// <param name="lastEvent">The last_event attribute value.</param>
	/// <param name="createdAt">The created_at attribute value.</param>
	/// <param name="to">The to attribute value.</param>
	/// <param name="bcc">The bcc attribute value.</param>
	/// <param name="cc">The cc attribute value.</param>
	/// <param name="replyTo">The reply_to attribute value.</param>
	public Email(string id, string obj, string from, string subject, string html, string text, string lastEvent,
		DateTimeOffset createdAt, List<string> to, List<string> bcc, List<string> cc, List<string> replyTo)
	{
		Id = id;
		Object = obj;
		From = from;
		Subject = subject;
		Html = html;
		Text = text;
		LastEvent = lastEvent;
		CreatedAt = createdAt;
		To = to;
		Bcc = bcc;
		Cc = cc;
		ReplyTo = replyTo;
	}
}
