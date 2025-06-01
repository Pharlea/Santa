using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Digite o índice do usuário (0 a 6) ou qualquer outro para sair: ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int indice) || indice < 0 || indice > 6)
            {
                Console.WriteLine("Índice inválido. Encerrando.");
                break;
            }

            IUsuarioProxy usuario = FabricaUsuario.Usuario(indice);

            Console.WriteLine("Nome: " + usuario.GetNome());
            Console.WriteLine("Endereço: " + usuario.GetEndereco());
            Console.WriteLine();
        }
    }
}

public interface IUsuarioProxy
{
    string GetNome();
    string GetEndereco();
}

public class Usuario : IUsuarioProxy
{
    private string nome;
    private string endereco;
    private string senha;
    private string login;

    public Usuario(int id)
    {
        string[,] usuarios = new string[,]
        {
            {"José Carlos" ,"Rua 5 Casa 4" ,"1234", "JOCA" },
            {"Pedro José" ,"Rua 13 de maio" ,"4321", "PEDRO" },
            {"Ana Maria" ,"Rua de baixo S/N" ,"4423", "ANINHA"},
            {"Diego Augusto" ,"Rua Olavo Bilac" ,"8899", "DIEGO" },
            {"Wendel Bezerra" ,"Rua Central 123" ,"5566", "GOKU" },
            {"Guilherme Briggs" ,"Rua Frontal 321" ,"7788", "KLARK" },
            {"Manolo Rey" ,"Rua de trás 456" ,"9900", "ROBIN" }
        };

        if (id >= 0 && id < usuarios.GetLength(0))
        {
            nome = usuarios[id, 0];
            endereco = usuarios[id, 1];
            senha = usuarios[id, 2];
            login = usuarios[id, 3];
        }
        else
        {
            throw new ArgumentException("ID inválido");
        }
    }

    public string GetNome()
    {
        return nome;
    }

    public string GetEndereco()
    {
        return endereco;
    }

    public string GetSenha()
    {
        return senha;
    }

    public string GetLogin()
    {
        return login;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public void SetEndereco(string endereco)
    {
        this.endereco = endereco;
    }

    public void SetSenha(string senha)
    {
        this.senha = senha;
    }

    public void SetLogin(string login)
    {
        this.login = login;
    }
}

public class FabricaUsuario
{
    public static IUsuarioProxy Usuario(int id)
    {
        return new Usuario(id);
    }
}



