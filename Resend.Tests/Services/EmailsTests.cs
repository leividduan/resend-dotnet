using NSubstitute;
using Resend.Services.Emails.Model;

namespace Resend.Tests.Services;

public class EmailsTests
{
	private readonly IEmails _emails = Substitute.For<IEmails>();

	[Fact]
	public void Retrieve_Email_Success()
	{
		// Arrange
		var expectedEmail = new Email(
			"qwert",
			"email_object",
			"sender@example.com",
			"Test Email Subject",
			"<html><body>This is the HTML content</body></html>",
			"This is the plain text content",
			"last_event_status", DateTime.Now,
			new List<string> { "recipient@example.com" },
			new List<string> { "bcc@example.com" },
			new List<string> { "cc@example.com" },
			new List<string> { "replyto@example.com" }
		);

		_emails.Get(expectedEmail.Id).Returns(expectedEmail);

		// Act
		var response = _emails.Get(expectedEmail.Id);

		// Assert
		Assert.Equal(expectedEmail, response);
	}

	[Fact]
	public void Send_Email_Success()
	{
		// Arrange
		var sendEmailRequest = new SendEmailRequest("Acme <onboarding@resend.dev>", new List<string> { "example@resend.dev" }, "Test email",
			"Hello, this is a text email", null, null, null, "", null, null, null)
			.AddCc("cc@dev.com")
			.AddBcc("bcc@dev.com")
			.AddAttachments(new Attachment("test.pdf", "test.pdf", "./folder/test.pdf"))
			.AddTags(new Tag("Test", "true"));
		var expectResponse = new SendEmailResponse("mock_id");

		_emails.Send(sendEmailRequest).Returns(expectResponse);

		// Act
		var response = _emails.Send(sendEmailRequest);

		// Assert
		Assert.NotNull(response);
	}
}
