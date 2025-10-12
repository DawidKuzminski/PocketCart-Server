using Microsoft.AspNetCore.Mvc;
using PocketCart_Server.Application.Dtos.Requests;

namespace PocketCart_Server.Controllers.Carts;

[ApiController]
[Route("api/[controller]")]
public class CartsController : ControllerBase
{
	[HttpGet]
	public IActionResult GetCarts()
	{
		return Ok(new { Message = "Get all carts" });
	}

	[HttpPost]
	public IActionResult CreateCart()
	{
		return Created("", new { Message = "Create a new cart" });
	}

	[HttpDelete]
	public IActionResult DeleteCart([FromRoute] Guid id)
	{
		return NoContent();
	}

	[HttpPut]
	public IActionResult UpdateCart(
		[FromRoute] Guid id,
		[FromBody] UpdateCartRequest updateCartRequest)
	{
		return NoContent();
	}

	[HttpGet("{id}/items")]
	public IActionResult GetCartItems([FromRoute] Guid id)
	{
		return Ok(new { Message = $"Get items for cart {id}" });
	}

	[HttpPost("{id}/items")]
	public IActionResult AddCartItem([FromRoute] Guid id)
	{
		return Created("", new { Message = $"Add item to cart {id}" });
	}

	[HttpDelete("{id}/items/{itemId}")]
	public IActionResult DeleteCartItem([FromRoute] Guid id, [FromRoute] Guid itemId)
	{
		return NoContent();
	}

	[HttpPut("{id}/items/{itemId}")]
	public IActionResult UpdateCartItem([FromRoute] Guid id, [FromRoute] Guid itemId)
	{
		return NoContent();
	}

	[HttpPost("{id}/items/{itemId}/toggle")]
	public IActionResult ToggleCartItem([FromRoute] Guid id, [FromRoute] Guid itemId)
	{
		return NoContent();
	}
}
