using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using RiosDesierto_Front.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<UsuarioApiService>();
builder.Services.AddSingleton<TiposDocumentoAPIService>();

builder.Services.AddCors(opts =>
{
    opts.AddPolicy("Default", builder =>
    {
        builder.AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader();
             });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseCors("Default");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
