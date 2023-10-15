using NSubstitute;
using Resend.Services.ApiKeys.Model;

namespace Resend.Tests.Services;

public class ApiKeysTests
{
	private readonly IApiKeys _apiKeys = Substitute.For<IApiKeys>();

	[Fact]
	public void Create_ApiKey_Success()
	{
		// Arrange
		var expectedApiKey = new CreateApiKeyResponse("123", "re_123");
		var request = new CreateApiKeyRequest("prod", "full_access", "");

		_apiKeys.Create(request).Returns(expectedApiKey);

		// Act
		var result = _apiKeys.Create(request);

		// Assert
		Assert.Equal(expectedApiKey.Id, result.Id);
		Assert.Equal(expectedApiKey.Token, result.Token);
	}

	[Fact]
	public void Delete_ApiKey_Success()
	{
		// Arrange
		var apiKeyId = "123";

		_apiKeys.Remove(apiKeyId).Returns(true);

		// Act
		var result = _apiKeys.Remove(apiKeyId);

		Assert.True(result);
	}

	[Fact]
	public void List_ApiKeys_Success()
	{
		// Arrange
		var datetime = DateTime.Now;
		var expectedResponse = new ListApiKeysResponse(new List<ApiKeyItem>
		{
			new ("abcdefg-4321-5678-ijklmnop", "Production", datetime),
			new ("abcdefg-4321-5678-ijklmnop", "Staging", datetime),
		});

		_apiKeys.List().Returns(expectedResponse);

		// Act
		var response = _apiKeys.List();

		// Assert
		Assert.NotNull(response);
		Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
	}
}
