using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;
using PocketCart_Server.Domain.Entities.Cart;

namespace PocketCart_Server.Infrastructure.Persistence;

public class CartDbContext : DbContext
{
	public DbSet<Cart> Carts { get; init; }

	public CartDbContext(DbContextOptions options) : base(options)
	{ }

	public static CartDbContext Create(IMongoDatabase database) => new(new DbContextOptionsBuilder<CartDbContext>()
			.UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName)
			.Options);




	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Cart>().ToCollection("carts");
	}
}
