using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// add code to use sessions
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
}
);
// end code to use sessions


// code authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => {
    options.LoginPath = new PathString("/LogIn");
    options.AccessDeniedPath = new PathString("/LogIn");
    options.Cookie.Name = "robert_heijn_auth_cookie";
}
);

// code authentication authorization

builder.Services.AddRazorPages();

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

// add code use authentication
app.UseAuthentication();
// end

// add code to use sessions
app.UseSession();
// end

app.UseAuthorization();

app.MapRazorPages();

app.Run();
