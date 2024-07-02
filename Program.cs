using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Data;
using WatchStore_NguyenVanLuc_21K4080078.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<WatchStore_NguyenVanLuc_21K4080078.Services.ProductService>();
builder.Services.AddSingleton<WatchStore_NguyenVanLuc_21K4080078.Services.CartService>();
builder.Services.AddSingleton<WatchStore_NguyenVanLuc_21K4080078.Services.UserService>();
builder.Services.AddSingleton <WatchStore_NguyenVanLuc_21K4080078.Services.OrderService > ();
builder.Services.AddScoped<WatchStore_NguyenVanLuc_21K4080078.Services.UserState>(); // Thêm d?ch v? tr?ng thái ng??i dùng



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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
