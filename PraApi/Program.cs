using Microsoft.EntityFrameworkCore;
using PraApi.Models;

var builder = WebApplication.CreateBuilder(args);

// 👉 Добавляем поддержку переменной окружения PORT
var port = Environment.GetEnvironmentVariable("PORT") ?? "80";
builder.WebHost.UseUrls($"http://*:{port}");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Убираем HTTPS редирект — он ломает всё на Railway
// app.UseHttpsRedirection(); ❌ УДАЛИ ИЛИ ЗАКОММЕНТЬ

app.UseAuthorization();

app.MapControllers();

// Можно добавить временный hello world для проверки
app.MapGet("/", () => "API работает!");

app.Run();
