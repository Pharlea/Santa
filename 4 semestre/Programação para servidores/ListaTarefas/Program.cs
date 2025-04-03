using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("DbListaDeTarefas")); //construtor do banco de dados (e o nome) + o aspnet passa automaticamente essa classe como argumento
var app = builder.Build();

//obter todos as tarefas
app.MapGet("/tarefa", (AppDbContext db) => {
    
    var todasTarefas = db.tbTarefas.ToList();

    return Results.Ok(todasTarefas);
});

//criar uma tarefa
app.MapPost("/tarefa", (AppDbContext db, Tarefa _umaTarefa) => {
    
    if (_umaTarefa.status != "Para fazer" && _umaTarefa.status != "Em andamento" && _umaTarefa.status != "Concluído") { return Results.BadRequest();}

    db.tbTarefas.Add(_umaTarefa);
    db.SaveChanges();

    return Results.Created($"/tarefa/{_umaTarefa.id}", _umaTarefa);
});

//atualiza uma tarefa
app.MapPut("/tarefa/{id}", (AppDbContext db, Tarefa _umaTarefa, int id) => {
    var tarefaExistente = db.tbTarefas.Find(id);

    if(tarefaExistente is null) {return Results.NotFound();}
    if (_umaTarefa.status != "Para fazer" && _umaTarefa.status != "Em andamento" && _umaTarefa.status != "Concluído") { return Results.BadRequest();}

    tarefaExistente.titulo = _umaTarefa.titulo;
    tarefaExistente.descricao = _umaTarefa.descricao;
    tarefaExistente.status = _umaTarefa.status;
    tarefaExistente.data = _umaTarefa.data;

    db.SaveChanges();

    return Results.NoContent();
});

//remover um tarefa
app.MapDelete("/tarefa/{id}", (AppDbContext db, int id) => {
    var tarefaExistente = db.tbTarefas.Find(id);

    if(tarefaExistente is null) {return Results.NotFound();}

    db.tbTarefas.Remove(tarefaExistente);
    db.SaveChanges();

    return Results.NoContent();
});

//obter por id
app.MapGet("/tarefa/{id}", (AppDbContext db, int id) => {
    var tarefaExistente = db.tbTarefas.Find(id);

    if(tarefaExistente is null) {return Results.NotFound();}

    return Results.Ok(tarefaExistente);
});

//obeter baseado em status
app.MapGet("/tarefa/getStatus/{status}", (AppDbContext db, string _status) => {
        var tarefasDeStatus = db.tbTarefas.Where(tarefa => tarefa.status == _status).ToList();

        if(tarefasDeStatus is null) {return Results.NotFound();}

        return Results.Ok(tarefasDeStatus);
});

//avançar status
app.MapPut("/AvancaStatusTarefa/{id}" , (AppDbContext db, int id) => {
    var tarefaExistente = db.tbTarefas.Find(id);

    if(tarefaExistente is null) {return Results.NotFound();}

    if(tarefaExistente.status == "Para fazer") 
    {
        tarefaExistente.status = "Em andamento";
        db.SaveChanges();
        return Results.NoContent();
    }
    if(tarefaExistente.status == "Em andamento")
    {
        tarefaExistente.status = "Concluído";
        tarefaExistente .data = "" + System.DateTime.Today;
        db.SaveChanges();
        return Results.NoContent();
    }

    return Results.BadRequest();
});

app.Run();
