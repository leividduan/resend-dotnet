using System.Text.Json.Serialization;

namespace Resend.Services.Emails.Model;

/// <summary>
/// Represents an attachment associated with an email.
/// </summary>
public class Attachment
{
	/// <summary>
	/// Get the filename of the attachment.
	/// </summary>
	[JsonPropertyName("filename")]
	public string FileName { get; private set; }

	/// <summary>
	/// Get the content of the attachment as a byte array.
	/// </summary>
	[JsonPropertyName("content")]
	public string Content { get; private set; }

	/// <summary>
	/// Get the path of the attachment.
	/// </summary>
	[JsonPropertyName("path")]
	public string Path { get; private set; }

	/// <summary>
	/// Create a new Attachment.
	/// </summary>
	/// <param name="fileName">The filename of the attachment.</param>
	/// <param name="content">The content of the attachment as a byte array.</param>
	/// <param name="path">The path of the attachment.</param>
	public Attachment(string fileName, string content, string path)
	{
		FileName = fileName;
		Content = content;
		Path = path;
	}
}
