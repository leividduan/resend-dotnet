using Resend.Services.ApiKeys;
using Resend.Services.Domains;
using Resend.Services.Emails;
using Resend.Services.Interfaces;

namespace Resend;

/// <summary>
/// The Resend class provides a facade for the Domains and Emails services.
/// </summary>
public class Resend
{
    /// <summary>
    /// The API key for the Resend service.
    /// </summary>
    private string ApiKey { get; init; }

    /// <summary>
    /// Returns an ApiKeys object that can be used to interact with the ApiKeys service.
    /// </summary>
    public IApiKeys ApiKeys => new ApiKeys(this.ApiKey);

    /// <summary>
    /// Returns a Domains object that can be used to interact with the Domains service.
    /// </summary>
    public IDomains Domains => new Domains(this.ApiKey);

    /// <summary>
    /// Returns an Emails object that can be used to interact with the Emails service.
    /// </summary>
    public IEmails Emails => new Emails(this.ApiKey);

    /// <summary>
    /// Constructs a new Resend with the specified API key.
    /// </summary>
    /// <param name="apiKey">
    /// The API key for the ReSend service.
    /// </param>
    public Resend(string apiKey)
    {
        ApiKey = apiKey;
    }
}
