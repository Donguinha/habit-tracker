using HabitTracker.Application.Services;
using HabitTracker.Identity.Services;
using HabitTracker.Infrastructure;
using Hangfire;
using Hangfire.SQLite;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SqliteDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddHangfire(config =>
    {
        config
            .UseSimpleAssemblyNameTypeSerializer()
            .UseRecommendedSerializerSettings()
            .UseSQLiteStorage("Data Source=hangfire.db;");
    }
);

builder.Services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<SqliteDbContext>();

builder.Services.AddRazorPages();

builder.Services.AddScoped<IIdentityService, IdentityService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseHangfireDashboard();

app.MapRazorPages();

app.Run();
