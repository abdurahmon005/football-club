using Microsoft.EntityFrameworkCore;
using foodball.Data;

var builder = WebApplication.CreateBuilder(args);

// EF Core ni ro‘yxatdan o‘tkazish
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Kontrollerlar
builder.Services.AddControllers();

// 🔥 Swagger xizmatlari
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI ni yoqish (faqat Developmentda)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
