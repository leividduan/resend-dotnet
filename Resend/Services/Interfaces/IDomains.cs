using Resend.Services.Domains.Models;

namespace Resend.Services.Interfaces;

public interface IDomains
{
	public CreateDomainResponse Create(CreateDomainRequest createDomainRequest);
	public Domain Get(string domainId);
	public VerifyDomainResponse Verify(string domainId);
	public ListDomainsResponse List();
	public RemoveDomainResponse Remove(string domainId);
}
