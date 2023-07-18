using myfinance_web_netcore;
using myfinance_web_netcore.Application.ObterPlanoConta;
using myfinance_web_netcore.Services.Interfaces;
using myfinance_web_netcore.Repository.Interfaces;
using myfinance_web_netcore.Repository;
using myfinance_web_netcore.Service.PlanoContaService;
using myfinance_web_netcore.Application.CadastrarPlanoConta;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyFinanceDbContext>();

builder.Services.AddScoped<IObterPlanoConta,ObterPlanoConta>();
builder.Services.AddScoped<ICadastrarPlanoConta,CadastrarPlanoConta>();
builder.Services.AddScoped<IPlanoContaService,PlanoContaService>();
builder.Services.AddScoped<IPlanoContaRepository,PlanoContaRepository>();

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
