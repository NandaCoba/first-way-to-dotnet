var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/", () =>
{
    return new { name = "nanda", usia = 19 };
});


app.MapPost("/user", (UserRequest req) =>
{
    return Results.Ok(new { message = $"user {req.name} dengan usia {req.age} telah di tambahkan" });
});


app.Run();

