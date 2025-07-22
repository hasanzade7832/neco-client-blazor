using BlazorApp12.Components;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// ⬅️ ۱. Razor Components برای حالت Server
builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();   // در Preview‑9 هنوز همین نام است

// ⬅️ ۲. **ثبت سرویس‌های MudBlazor – حیاتی!**
builder.Services.AddMudServices();

var app = builder.Build();

// Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAntiforgery();

// ⬅️ ۳. Map کامپوننت ریشه و تعیین مود رندر
app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();   // یا ServerRenderMode در SDKهای جدیدتر

app.Run();
