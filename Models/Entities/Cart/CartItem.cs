using MongoDB.Bson.Serialization.Attributes;

namespace PocketCart_Server.Models.Entities.Cart;

public record CartItem
{
	[BsonElement("id")]
	public required Guid Id { get; set; }

	[BsonElement("name")]
	public required string Name { get; set; }

	[BsonElement("amount")]
	public required int Amount { get; set; }

	[BsonElement("category")]
	public required string Category { get; set; }
}
