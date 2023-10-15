using System.Text.Json.Serialization;

namespace Resend.Services.Domains.Models;

/// <summary>
/// Represents a DNS record associated with a domain.
/// </summary>
public class Record
{
	/// <summary>
	/// The record.
	/// </summary>
	[JsonPropertyName("record")]
	public string RecordType { get; private set; }

	/// <summary>
	/// The record name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; private set; }

	/// <summary>
	/// The record type.
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; private set; }

	/// <summary>
	/// The TTL value.
	/// </summary>
	[JsonPropertyName("ttl")]
	public string Ttl { get; private set; }

	/// <summary>
	/// The status of the record.
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; private set; }

	/// <summary>
	/// The record value.
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; private set; }

	/// <summary>
	/// The priority of the record. (Optional)
	/// </summary>
	[JsonPropertyName("priority")]
	public int Priority { get; private set; }

	public Record()
	{
	}

	/// <summary>
	/// Constructor to create an immutable Record instance.
	/// </summary>
	/// <param name="record">The record type.</param>
	/// <param name="name">The record name.</param>
	/// <param name="type">The record type.</param>
	/// <param name="ttl">The TTL value.</param>
	/// <param name="status">The status of the record.</param>
	/// <param name="value">The record value.</param>
	/// <param name="priority">The priority of the record. (Optional)</param>
	public Record(string record, string name, string type, string ttl, string status, string value, int priority)
	{
		RecordType = record;
		Name = name;
		Type = type;
		Ttl = ttl;
		Status = status;
		Value = value;
		Priority = priority;
	}

}
