using Resend.Services.ApiKeys.Model;

namespace Resend.Services.Interfaces;

public interface IApiKeys
{
	public CreateApiKeyResponse Create(CreateApiKeyRequest createApiKeyRequest);
	public ListApiKeysResponse List();
	public bool Remove(string apiKeyId);
}
