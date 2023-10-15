using System.Text.Json.Serialization;

namespace Resend.Services.Emails.Model;

/// <summary>
/// Represents a request to send an email.
/// </summary>
public class SendEmailRequest
{
	/// <summary>
	///The sender's email address.
	/// </summary>
	[JsonPropertyName("from")]
	public string From { get; private set; }

	/// <summary>
	/// The list of recipients' email addresses.
	/// </summary>
	[JsonPropertyName("to")]
	private List<string> To { get; set; }

	/// <summary>
	/// The email subject.
	/// </summary>
	[JsonPropertyName("subject")]
	public string Subject { get; private set; }

	/// <summary>
	/// The plain text version of the message.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; private set; }

	/// <summary>
	/// The list of recipient email addresses.
	/// </summary>
	[JsonPropertyName("cc")]
	private List<string>? Cc { get; set; }

	/// <summary>
	/// The list of recipient email addresses.
	/// </summary>
	[JsonPropertyName("bcc")]
	private List<string>? Bcc { get; set; }

	/// <summary>
	/// The plain text version of the message.
	/// </summary>
	[JsonPropertyName("reply_to")]
	private List<string>? ReplyTo { get; set; }

	/// <summary>
	/// The HTML version of the message.
	/// </summary>
	[JsonPropertyName("html")]
	public string Html { get; private set; }

	/// <summary>
	/// The custom headers of the email.
	/// </summary>
	[JsonPropertyName("headers")]
	private Dictionary<string, string>? Headers { get; set; }

	/// <summary>
	/// The list of attachments of the email.
	/// </summary>
	[JsonPropertyName("attachments")]
	private List<Attachment>? Attachments { get; set; }

	/// <summary>
	/// The tags of the email.
	/// </summary>
	[JsonPropertyName("tags")]
	private List<Tag>? Tags { get; set; }

	/// <summary>
	/// Creates a new instance of SendEmailRequest.
	/// </summary>
	/// <param name="from">The sender's email address.</param>
	/// <param name="to">The list of recipients' email addresses.</param>
	/// <param name="subject">The email subject.</param>
	/// <param name="text">The plain text version of the message.</param>
	/// <param name="cc">The list of recipient email addresses.</param>
	/// <param name="bcc">The list of recipient email addresses.</param>
	/// <param name="replyTo">The plain text version of the message.</param>
	/// <param name="html">The HTML version of the message.</param>
	/// <param name="headers">The custom headers of the email.</param>
	/// <param name="attachments">The list of attachments of the email.</param>
	/// <param name="tags">The tags of the email.</param>
	public SendEmailRequest(string from, List<string> to, string subject, string text, List<string>? cc,
		List<string>? bcc, List<string>? replyTo, string html, Dictionary<string, string>? headers,
		List<Attachment>? attachments, List<Tag>? tags)
	{
		From = from;
		To = to;
		Subject = subject;
		Text = text;
		Cc = cc;
		Bcc = bcc;
		ReplyTo = replyTo;
		Html = html;
		Headers = headers;
		Attachments = attachments;
		Tags = tags;
	}

	public SendEmailRequest SetTo(List<string> recipients)
	{
		To = recipients;
		return this;
	}

	public SendEmailRequest AddTo(string recipient)
	{
		To.Add(recipient);
		return this;
	}

	public SendEmailRequest AddTo(IEnumerable<string> recipients)
	{
		foreach (var recipient in recipients)
			To.Add(recipient);

		return this;
	}

	public SendEmailRequest SetCc(List<string> ccs)
	{
		Cc = ccs;
		return this;
	}

	public SendEmailRequest AddCc(string cc)
	{
		Cc ??= new List<string>();

		Cc.Add(cc);
		return this;
	}

	public SendEmailRequest AddCc(IEnumerable<string> ccs)
	{
		Cc ??= new List<string>();

		foreach (var cc in ccs)
			Cc.Add(cc);

		return this;
	}

	public SendEmailRequest SetBcc(List<string> bccs)
	{
		Bcc = bccs;
		return this;
	}

	public SendEmailRequest AddBcc(string bcc)
	{
		Bcc ??= new List<string>();

		Bcc.Add(bcc);
		return this;
	}

	public SendEmailRequest AddBcc(IEnumerable<string> bccs)
	{
		Bcc ??= new List<string>();

		foreach (var bcc in bccs)
			Bcc.Add(bcc);

		return this;
	}

	public SendEmailRequest SetReplyTo(List<string> repliesTo)
	{
		ReplyTo = repliesTo;
		return this;
	}

	public SendEmailRequest AddReplyTo(string replyTo)
	{
		ReplyTo ??= new List<string>();

		ReplyTo.Add(replyTo);
		return this;
	}

	public SendEmailRequest AddReplyTo(IEnumerable<string> repliesTo)
	{
		ReplyTo ??= new List<string>();

		foreach (var replyTo in repliesTo)
			ReplyTo.Add(replyTo);

		return this;
	}

	public SendEmailRequest SetHeaders(Dictionary<string, string> headers)
	{
		Headers = headers;
		return this;
	}

	public SendEmailRequest AddHeaders(string key, string value)
	{
		Headers ??= new Dictionary<string, string>();

		Headers[key] = value;
		return this;
	}

	public SendEmailRequest SetAttachments(List<Attachment> attachments)
	{
		Attachments = attachments;
		return this;
	}

	public SendEmailRequest AddAttachments(Attachment attachment)
	{
		Attachments ??= new List<Attachment>();

		Attachments.Add(attachment);
		return this;
	}

	public SendEmailRequest AddAttachments(IEnumerable<Attachment> attachments)
	{
		Attachments ??= new List<Attachment>();

		foreach (var attachment in attachments)
			Attachments.Add(attachment);

		return this;
	}

	public SendEmailRequest SetTags(List<Tag> tags)
	{
		Tags = tags;
		return this;
	}

	public SendEmailRequest AddTags(Tag tag)
	{
		Tags ??= new List<Tag>();

		Tags.Add(tag);
		return this;
	}

	public SendEmailRequest AddTags(IEnumerable<Tag> tags)
	{
		Tags ??= new List<Tag>();

		foreach (var tag in tags)
			Tags.Add(tag);

		return this;
	}
}
