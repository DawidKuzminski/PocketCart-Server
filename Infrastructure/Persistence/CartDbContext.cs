using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;
using PocketCart_Server.Models.Entities.Cart;

namespace PocketCart_Server.Infrastructure.Persistence;

public class CartDbContext : DbContext
{
	public DbSet<Cart> Carts => Set<Cart>();

	public CartDbContext(DbContextOptions options) : base(options)
	{ }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Cart>().ToCollection("carts");
	}
}
