using Microsoft.EntityFrameworkCore;
using Test.Domain.Model.DbModel;
using Test.Domain.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TestContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TestWebAppContext") ?? throw new InvalidOperationException("Connection string 'TestWebAppContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

//Injección de dependencias
builder.Services.AddScoped<IEmpleadoService, EmpleadoService>();
builder.Services.AddScoped<ICargoService, CargoService>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
