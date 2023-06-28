using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Parashumti_hw5_RazorPagesAndAzure.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Parashumti_hw5_RazorPagesAndAzureContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Parashumti_hw5_RazorPagesAndAzureContext") ?? throw new InvalidOperationException("Connection string 'Parashumti_hw5_RazorPagesAndAzureContext' not found.")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
