using AppBugaoMotoFVLE.Components;
using AppBugaoMotoFVLE.Components.Models;
using AppBugaoMotoFVLE.Configs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
//Codigo para listagem de fornecedor


builder.Services.AddSingleton<AppBugaoMotoFVLE.Configs.Conexao>();
builder.Services.AddSingleton<AppBugaoMotoFVLE.Components.Models.FornecedorDAO>();
//builder.Services.AddScoped<AppBugaoMotoFVLE.Models.ProdutoDAO>();
//Adicionar a linha acima antes de `var app = builder.Build();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
