namespace Resend.Core.Exception;

/// <summary>
/// Custom exception class for representing errors related to the Resend API.
/// </summary>
public class ResendException : System.Exception
{
	/// <summary>
	/// Constructs a new `ResendException` with the specified error message.
	/// </summary>
	/// <param name="message">
	/// The error message describing the exception.
	/// </param>
	public ResendException(string? message) : base(message)
	{
	}

	/// <summary>
	/// Constructs a new `ResendException` with the specified error message and cause.
	/// </summary>
	/// <param name="message">
	/// The error message describing the exception.
	/// </param>
	/// <param name="innerException">
	/// The cause of the exception.
	/// </param>
	public ResendException(string? message, System.Exception? innerException) : base(message, innerException)
	{
	}
}
