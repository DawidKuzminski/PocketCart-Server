using Microsoft.AspNetCore.SignalR;
using PocketCart_Server.Models.Entities.Cart;

namespace PocketCart_Server.Infrastructure.Services.Notifications;

public sealed class CartNotificationHub : Hub
{
	public async Task SendCartAdded(Cart cart)
	{
		await Clients.All.SendAsync("CartAdded", cart);
	}
}
