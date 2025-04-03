var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
Candidato umCandidato = new Candidato();
guardaCandidato guarda = new guardaCandidato();

app.MapGet("/", () => {
    return Results.Ok(guarda.getNome(umCandidato.id()));
});

app.MapPost("/Candidato", (umCandidato) => {
    guarda.setId(umCandidato.id);
    guarda.setNome(umCandidato.nome);
    guarda.setTelefone(umCandidato.telefone);
    guarda.setDataDeNascimento(umCandidato.dataDeNascimento);
});

app.MapPut("/Candidato/{id}", () => {
    return Results.Ok(umCandidato);
});















app.Run();

public class Candidato
{
    public int id { get; set; }
    public string nome { get; set; }
    public string telefone { get; set; }
    public string dataDeNascimento { get; set; }
}


public class guardaCandidato
{
    List<int> id = new List<int>();
    List<string> nome = new List<string>();
    List<string> telefone = new List<string>();
    List<string> dataDeNascimento = new List<string>();

    public void setId (int _id)
    {
        id.Add(_id);
    }

    public void setNome (string _nome)
    {
        nome.Add(_nome);
    }

    public void setTelefone (string _telefone)
    {
        nome.Add(_telefone);
    }

    public void setDataDeNascimento (string _dataDeNascimento)
    {
        nome.Add(_dataDeNascimento);
    }

    public int getId (int _i)
    {
        return id[_i];
    }

    public string getNome (int _i)
    {
        return nome[_i];
    }

    public string getTelefone (int _i)
    {
        return telefone[_i];
    }

    public string getDataDeNascimento (int _i)
    {
        return dataDeNascimento[_i];
    }

    
}