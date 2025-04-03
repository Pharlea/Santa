using ApiAuth;
using ApiAuth.Models;
using ApiAuth.Repositories;
using ApiAuth.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Configura��o para habilitar autentica��o
var key = Encoding.ASCII.GetBytes(Setting.Secret);

builder.Services.AddAuthentication(x =>
{
    //Definir o esquema de autentica��o
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    // � a forma como ele vai interrogar a requisia��o para saber como lidar e saber onde est� o token 
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    // Configurar os parametros do Token
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true, // Validar a chave de assinatura
        IssuerSigningKey = new SymmetricSecurityKey(key), // Como ele valida essa chave
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

// Configura��o para tratar autoriza��o
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", policy => policy.RequireRole("gerente"));
    options.AddPolicy("Estagiario", policy => policy.RequireRole("estagiario"));
});

// Isso j� tava
var app = builder.Build();

// Precisa addd nessa ordem
app.UseAuthentication();
app.UseAuthorization();


// Metodos
app.MapPost("/login", (User umUsuario) => {
    //ir no banco buscar se o usu�rio existe e se a senha � igual
    var usuario = UserRepository.Get(umUsuario.UserName, umUsuario.Password);

    if (usuario == null) { return Results.NotFound(new {message = "Usuario ou senha inv�lido!"}); }

    var token = TokenService.GenerateToken(usuario);

    return Results.Ok(token);
});

app.MapGet("/teste", () =>
{
    return Results.Ok("Funcionou sem autenticar!");
});

app.MapGet("/autenticado", () =>
{
    return Results.Ok("Funcionou autenticado!");
}).RequireAuthorization();

app.MapGet("/saldo", (ClaimsPrincipal user) =>
{
    /*buscar algo no banco referente ao usu�rio, 
     posso usar esse argumento ClaimsPrincipal para obter
     informa��es do usu�rio contidas no token
     EX: user.Identity.Name;*/

    return Results.Ok("Saldo atual: R$ 230,00");
}).RequireAuthorization("Admin");
app.Run();