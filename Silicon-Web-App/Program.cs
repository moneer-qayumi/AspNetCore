using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Entities;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("LocalDatabase")));

builder.Services.AddDefaultIdentity<UserEntity>(X =>
{
    X.User.RequireUniqueEmail = true;   
    X.SignIn.RequireConfirmedAccount =false;
    X.Password.RequiredLength = 8; 
}).AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<AddressManager>();

var app = builder.Build();
app.UseHsts();
//app.UseStatusCodePagesWithReExecute("/error", "?statusCode={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
