using Microsoft.AspNetCore.Authentication;

namespace Backend.Endpoints;

public static class AuthEndpoints
{
    public static WebApplication MapAuthEndpoints(this WebApplication app)
    {
        app.MapGet("/Logout", async (HttpContext httpContext) =>
        {
            await httpContext.SignOutAsync();
            return Results.Redirect("/");
        });

        return app;
    }
}
