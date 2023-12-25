var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.MapGet("/", () => {
    string msg = """
<!DOCTYPE html>
<html lang="uk">
<head>
<meta charset="utf-8">
<title>Get-запит</title>
</head>
<body>
<h1>Доброго дня!</h1>
<p style="color:gray">
Для створення Get=запиту у URL додайте "/Home/Index?" після чого зачніть вписувати числові параметри, наприклад:
option[0]=5&option[1]=10. Программа видасть кількість параметрів та їх сумму.
</p>
<hr>
</body>
</html>
""";
    return Results.Content(msg, "text/html");
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();