using Resend.Services.Emails.Model;

namespace Resend.Services.Interfaces;

public interface IEmails
{
	public SendEmailResponse Send(SendEmailRequest sendEmailRequest);
	public Email Get(string emailId);
}
