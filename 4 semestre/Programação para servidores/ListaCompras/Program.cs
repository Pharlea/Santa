using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("DbListaDeCompras")); //construtor do banco de dados (e o nome) + o aspnet passa automaticamente essa classe como argumento
var app = builder.Build();

//obter todos os produtos
app.MapGet("/produto", (AppDbContext db) => {
    
    var todosProdutos = db.tbProdutos.ToList();

    return Results.Ok(todosProdutos);
});

//criar um produto
app.MapPost("/produto", (AppDbContext db, Produto _umProduto) => {
    
    db.tbProdutos.Add(_umProduto);
    db.SaveChanges();

    return Results.Created($"/produto/{_umProduto.Id}", _umProduto);
});

//atualiza um produto 
app.MapPut("/produto/{Id}", (AppDbContext db, Produto _umProduto, int _id) => {
    var produtoExistente = db.tbProdutos.Find(_id);

    if(produtoExistente is null) {return Results.NotFound();}

    produtoExistente.Nome = _umProduto.Nome;
    produtoExistente.Quantidade = _umProduto.Quantidade;
    produtoExistente.Comprado = _umProduto.Comprado;

    db.SaveChanges();

    return Results.NoContent();
});

//remover um produto
app.MapDelete("/produto/{Id}", (AppDbContext db, int _id) => {
    var produtoExistente = db.tbProdutos.Find(_id);

    if(produtoExistente is null) {return Results.NotFound();}

    db.tbProdutos.Remove(produtoExistente);
    db.SaveChanges();

    return Results.NoContent();
});

//obter por id
app.MapGet("/produto{Id}", (AppDbContext db, int _id) => {
    var produtoExistente = db.tbProdutos.Find(_id);

    if(produtoExistente is null) {return Results.NotFound();}

    return Results.Ok(produtoExistente);
});

app.Run();
