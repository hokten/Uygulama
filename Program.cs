using Microsoft.EntityFrameworkCore;
using Uygulama.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<StoreDbContext>(opts => {
	opts.UseSqlServer(builder.Configuration["ConnectionStrings:vt"]);
});
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
