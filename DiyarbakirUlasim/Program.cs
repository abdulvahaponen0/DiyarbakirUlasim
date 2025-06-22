using Business;
using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // Session'ý ekle

builder.Services.AddDbContext<YolcuDbContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString
("DefaultConnection")));
builder.Services.AddScoped<IYolcuLogin,YolcuLogin>();
builder.Services.AddScoped<IYolcuLoginBusiness, YolcuLoginBusiness>();
builder.Services.AddScoped<IKrediKartiIslemleri,KrediKartiIslemleri>();
builder.Services.AddScoped<IKrediKArtiIslemleriBusiness,KrediKArtiIslemleriBusiness>();
builder.Services.AddScoped<IKartDataAccess,KartDataAccess>();
builder.Services.AddScoped<IKartBusiness,KartBusines>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseSession(); // Session middleware'i ekle

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
