using EventEase.Components;

var builder = WebApplication.CreateBuilder(args);

// Register scoped services for session and attendance tracking
builder.Services.AddScoped<SessionStateService>();
builder.Services.AddScoped<AttendanceService>();

// Enable Razor components with interactive server rendering
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Error handling and security settings for production
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts(); // Enforce HTTPS with HTTP Strict Transport Security
}

// Middleware pipeline
app.UseHttpsRedirection();       // Redirect HTTP to HTTPS
app.UseAntiforgery();            // Protect against CSRF

app.MapStaticAssets();          // Serve static content (CSS, JS, etc.)
app.MapRazorComponents<App>()   // Map Razor pages
    .AddInteractiveServerRenderMode(); // Enable server-side interactivity

app.Run(); // Launch the application
