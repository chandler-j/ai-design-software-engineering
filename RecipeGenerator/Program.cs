using System;
using Microsoft.Extensions.DependencyInjection;
using OpenAI.Extensions;
using OpenAI.Interfaces;
using RecipeGenerator;

var builder = WebApplication.CreateBuilder(args);
{

    // Add services to the container.
    builder.Services.AddControllersWithViews();
    builder.Services.AddControllers().AddNewtonsoftJson();
    builder.Services.AddOpenAIService();
    builder.Services.AddInfrastructure();

}


var app = builder.Build();
{
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

}

