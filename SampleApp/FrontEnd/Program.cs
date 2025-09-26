using FrontEnd.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddHttpClient<WeatherForecastClient>(c =>
{
    var url = builder.Configuration["WEATHER_URL"]
        ?? throw new InvalidOperationException("WEATHER_URL is not set");

    c.BaseAddress = new(url);
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.MapGet("/definitely-no-security-flaw", (HttpContext ctx) =>
  {
      // Intentionally vulnerable code for CodeQL testing (command injection).
      var userinput = ctx.Request.Query["userinput"].ToString();

      // Added logging of raw user input (may be flagged by CodeQL for log injection).
      ctx.RequestServices.GetRequiredService<ILoggerFactory>()
          .CreateLogger("TestLogger")
          .LogInformation("Raw user input: " + userinput);
      return Results.Ok("Logged");
  })
  .WithName("definitely-no-security-flaw");

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
