using BlazorApp12.Components;     // ⬅️ کامپوننت ریشه
using MudBlazor.Services;         // ⬅️ سرویس‌های MudBlazor

var builder = WebApplication.CreateBuilder(args);

// ─────────────────────────────────────────────────────────────
// ۱. سرویس‌ها
// ─────────────────────────────────────────────────────────────
builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();   // در SDK‑های جدیدتر AddServerRenderMode()

builder.Services.AddMudServices();                  // MudBlazor

// اگر سرویس دیگری (HttpClient، Auth و …) دارید اینجا اضافه کنید
// …

var app = builder.Build();

// ─────────────────────────────────────────────────────────────
// ۲. Pipeline
// ─────────────────────────────────────────────────────────────
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();      // ⬅️ حیاتی برای بارگذاری CSS/JS
app.UseRouting();
app.UseAntiforgery();      // Razor Components نیاز دارد

// ─────────────────────────────────────────────────────────────
// ۳. Map کامپوننت ریشه
// ─────────────────────────────────────────────────────────────
app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();   // یا .AddServerRenderMode() در RC/RTM

app.Run();
