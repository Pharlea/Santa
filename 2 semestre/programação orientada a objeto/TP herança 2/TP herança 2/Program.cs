////exercício 1
//class AlunoGraduacao
//{
//    public int matricula { get; set; }
//    public string nome { get; set; }
//    private int codigoDoCurso;
//    public float mensalidade;

//    public void Getcodigo()
//    {
//        do
//        {
//            Console.Write("1- arquitetura\n2- sistemas de informação\n3- engenharia\n4- biomedicina\ncurso: ");
//            int.TryParse(Console.ReadLine(), out codigoDoCurso);
//        } while (codigoDoCurso < 1 || codigoDoCurso > 4);

//        DefineMensalidade();
//    }

//    public void DefineMensalidade()
//    {
//        switch (codigoDoCurso)
//        {
//            case 1: mensalidade = 450; break;
//            case 2: mensalidade = 650; break;
//            case 3: mensalidade = 850; break;
//            case 4: mensalidade = 750; break;
//        }
//    }
//}

//class AlunoPosGraduacao : AlunoGraduacao
//{
//    public string LinhaDePesquisa { get; set; }
//    public string orientador { get; set; }
//    public float ValorBolsaEstudos { get; set; }

//    public void CalculaMensalidade()
//    {
//        mensalidade -= ValorBolsaEstudos;
//    }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        int escolha;
//        do
//        {
//            Console.Write("1- graduação\n2- pós graduação\nvocê está fazendo graduação ou pós graduação? ");
//            int.TryParse(Console.ReadLine(), out escolha);
//        } while (escolha != 1 && escolha != 2);

//        switch (escolha)
//        {
//            case 1: Graduado(); break;
//            case 2: PosGraduado(); break;
//        }
//    }

//    static void Graduado()
//    {
//        AlunoGraduacao alunoGraduacao = new AlunoGraduacao(); int temp;

//        do
//        {
//            Console.Write("nome: ");
//            alunoGraduacao.nome = Console.ReadLine();
//        } while (alunoGraduacao.nome == "");

//        do
//        {
//            Console.Write("número de matricula: ");
//            int.TryParse(Console.ReadLine(), out temp);  
//        } while (temp <= 0);
//        alunoGraduacao.matricula = temp;
//        alunoGraduacao.Getcodigo();

//        Console.WriteLine("o custo da mensalidade será de {0}R$", alunoGraduacao.mensalidade);
//    }

//    static void PosGraduado()
//    {
//        AlunoPosGraduacao alunoPosGraduacao = new AlunoPosGraduacao(); int temp;

//        do
//        {
//            Console.Write("nome: ");
//            alunoPosGraduacao.nome = Console.ReadLine();
//        } while (alunoPosGraduacao.nome == "");

//        do
//        {
//            Console.Write("número de matricula: ");
//            int.TryParse(Console.ReadLine(), out temp);
//        } while (temp <= 0);
//        alunoPosGraduacao.matricula = temp;
//        alunoPosGraduacao.Getcodigo();

//        do
//        {
//            Console.Write("linha de pesquisa: ");
//            alunoPosGraduacao.LinhaDePesquisa = Console.ReadLine();
//        } while (alunoPosGraduacao.LinhaDePesquisa == "");

//        do
//        {
//            Console.Write("orientador: ");
//            alunoPosGraduacao.LinhaDePesquisa = Console.ReadLine();
//        } while (alunoPosGraduacao.orientador == "");

//        do
//        {
//            Console.Write("valor da bolsa de estudos: ");
//            int.TryParse(Console.ReadLine(), out temp);
//            alunoPosGraduacao.ValorBolsaEstudos = temp;
//        } while (alunoPosGraduacao.ValorBolsaEstudos <= 0);

//        alunoPosGraduacao.CalculaMensalidade();

//        Console.WriteLine("o custo da mensalidade será de {0}R$", alunoPosGraduacao.mensalidade);
//    }
//}

//exercício 2

class veiculo
{
    public string marca { get; set; }
    public string modelo { get; set; }
    public int AnoDeFabricacao { get; set; }
    public string cor { get; set; }
}

class carro : veiculo
{
    public int NumeroDePortas { get; set; }

    public string TipoDetransmissao;

    public void SetTransmissao()
    {
        int escolha;
        
        do
        {
            Console.Write("1- automático\n2- manual\nescolha o tipo de transmissao: ");
            int.TryParse(Console.ReadLine(), out escolha);
        } while (escolha != 1 && escolha != 2);

        switch (escolha)
        {
            case 1: TipoDetransmissao = "automático"; break;
            case 2: TipoDetransmissao = "manual"; break;
        }
    }
}

class motocicleta : veiculo
{
    public int cilindradas { get; set; }
    public string TipoDePartida;

    public void SetPartida()
    {
        int escolha;

        do
        {
            Console.Write("1- elétrica\n2- manual\nescolha o tipo de transmissao: ");
            int.TryParse(Console.ReadLine(), out escolha);
        } while (escolha != 1 && escolha != 2);

        switch (escolha)
        {
            case 1: TipoDePartida = "elétrica"; break;
            case 2: TipoDePartida = "manual"; break;
        }
    }
}

class program
{
    static void Main(string[] args)
    {
        int temp;

        carro carro = new carro();
        motocicleta motocicleta = new motocicleta();

        Console.Write("marca do carro: ");
        carro.marca = Console.ReadLine();
        Console.Write("modelo do carro: ");
        carro.modelo = Console.ReadLine();
        do
        {
            Console.Write("ano de fabricação do carro: ");
            int.TryParse(Console.ReadLine(), out temp);
            carro.AnoDeFabricacao = temp;
        } while (carro.AnoDeFabricacao < 1885);
        Console.Write("cor do carro: ");
        carro.cor = Console.ReadLine();
        do
        {
            Console.Write("número de portas: ");
            int.TryParse(Console.ReadLine(), out temp);
            carro.NumeroDePortas = temp;
        } while (carro.NumeroDePortas < 2);
        carro.SetTransmissao();

        Console.Write("marca da moto: ");
        motocicleta.marca = Console.ReadLine();
        Console.Write("modelo da moto: ");
        motocicleta.modelo = Console.ReadLine();
        do
        {
            Console.Write("ano de fabricação da moto: ");
            int.TryParse(Console.ReadLine(), out temp);
            motocicleta.AnoDeFabricacao = temp;
        } while (motocicleta.AnoDeFabricacao < 1885);
        Console.Write("cor da moto: ");
        motocicleta.cor = Console.ReadLine();
        do
        {
            Console.Write("cilindradas: ");
            int.TryParse(Console.ReadLine(), out temp);
            motocicleta.cilindradas = temp;
        } while (motocicleta.cilindradas < 2);
        motocicleta.SetPartida();

        Console.WriteLine("ficha do carro: \n {0} portas, {1}, {2}, {3}, {4}, {5}", carro.NumeroDePortas, carro.marca, carro.modelo, carro.cor, carro.AnoDeFabricacao, carro.TipoDetransmissao);
        Console.WriteLine("ficha da moto: \n {0} cilindradas, {1}, {2}, {3}, {4}, partida {5}", motocicleta.cilindradas, motocicleta.marca, motocicleta.modelo, motocicleta.cor, motocicleta.AnoDeFabricacao, motocicleta.TipoDePartida);
    } 
}