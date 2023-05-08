using Microsoft.EntityFrameworkCore;
using Shop.DAL.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString
    = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ShopContext>(options =>
options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddControllers().AddJsonOptions
    (x => x.JsonSerializerOptions.ReferenceHandler = null);

builder.Services.AddControllers().AddNewtonsoftJson
    (x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
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

using (var scope = app.Services.CreateScope())
{
    var myContext = scope.ServiceProvider.GetRequiredService<ShopContext>();
    DBInitializer.Initialize(myContext);
}

app.Run();
