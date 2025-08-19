using MongoDB.Bson.Serialization.Attributes;

namespace PocketCart_Server.Domain.Entities.Cart;

public record CartItem
{
	[BsonElement("id")]
	public required Guid Id { get; init; }

	[BsonElement("name")]
	public required string Name { get; init; }

	[BsonElement("amount")]
	public required int Amount { get; init; }

	[BsonElement("category")]
	public required string Category { get; set; }
}
