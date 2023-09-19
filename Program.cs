using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RANUISWANSONFOOTBALLCLUB_WEBSITEContext;
using Microsoft.AspNetCore.Identity;
using RANUISWANSONFOOTBALLCLUB_WEBSITE.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<db>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("db") ?? throw new InvalidOperationException("Connection string 'db' not found.")));

builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<db>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
