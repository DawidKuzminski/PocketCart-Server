using MongoDB.Bson.Serialization.Attributes;

namespace PocketCart_Server.Domain.Entities.Cart;

public record Cart
{
	[BsonId]
	public required Guid _id { get; set; }

	[BsonElement("name")]
	public required string Name { get; set; }

	[BsonElement("items")]
	public required IReadOnlyList<CartItem> Items { get; set; }
}
