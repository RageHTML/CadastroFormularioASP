var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

app.MapPost("/cadastro", (HttpRequest request) =>
{
    string nome = request.Form["nome_usuario"];
    int telefone = int.Parse(request.Form["telefone_usuario"]);
    int idade = int.Parse(request.Form["idade_usuario"]);

    return $"Nome: {nome} Idade: {idade}";
});

app.Run();