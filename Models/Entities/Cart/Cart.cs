using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PocketCart_Server.Models.Entities.Cart;

public record Cart
{
	[BsonId]
	[BsonRepresentation(BsonType.String)]
	public string Id { get; set; }

	[BsonElement("name")]
	public required string Name { get; set; }

	[BsonElement("items")]
	public required IReadOnlyList<CartItem> Items { get; set; }
}
