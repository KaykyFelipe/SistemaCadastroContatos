using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Data;
using SistemaCadastro.Repositorio;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BancoContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();//Toda vez que minha IContatoRepositorio dor chamada quero que ele usa todos atributos e metodos da ContatoRepositorio

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
