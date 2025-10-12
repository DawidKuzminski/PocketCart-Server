namespace PocketCart_Server.Application.Dtos.Requests;

public class UpdateCartRequest
{
	public required Guid Id { get; init; }
	public required string Name { get; init; }
}
