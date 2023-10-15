using Resend.Services.ApiKeys;
using Resend.Services.Domains;
using Resend.Services.Emails;

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
    public ApiKeys ApiKeys => new (this.ApiKey); 
    
    /// <summary>
    /// Returns a Domains object that can be used to interact with the Domains service.
    /// </summary>
    public Domains Domains => new (this.ApiKey); 
    
    /// <summary>
    /// Returns an Emails object that can be used to interact with the Emails service.
    /// </summary>
    public Emails Emails => new (this.ApiKey); 

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