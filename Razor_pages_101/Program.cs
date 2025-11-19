using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Razor_pages_101.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//add services to the container
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Razor_pages_101Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Razor_pages_101Context") ?? throw new InvalidOperationException("Connection string 'Razor_pages_101Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
// cofig the http
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // the default hsts value is 30 day
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
