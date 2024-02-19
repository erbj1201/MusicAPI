//include
using Microsoft.EntityFrameworkCore;
using MusicAPI.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Database connection
builder.Services.AddDbContext<MusicContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultDbConnection"))
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
