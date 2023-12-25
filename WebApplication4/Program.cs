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
<title>Get-�����</title>
</head>
<body>
<h1>������� ���!</h1>
<p style="color:gray">
��� ��������� Get=������ � URL ������� "/Home/Index?" ���� ���� ������ ��������� ������ ���������, ���������:
option[0]=5&option[1]=10. ��������� ������� ������� ��������� �� �� �����.
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