using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using PocketCart_Server.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
InitDatabase(builder.Services, builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void InitDatabase(IServiceCollection services, string connectionString)
{
	if (string.IsNullOrEmpty(connectionString))
		throw new InvalidOperationException("DefaultConnection environment variable is not set.");

	var mongoClient = new MongoClient(connectionString);

	services.AddSingleton(mongoClient);
	services.AddDbContext<CartDbContext>(options =>
		options.UseMongoDB(mongoClient, "PocketCart"));
}
