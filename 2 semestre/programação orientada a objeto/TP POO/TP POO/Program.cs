//exercício 1
//class program
//{
//    static void Main (string[] args)
//    {
//        funcionario funcionario = new funcionario();
//    }
//    class funcionario
//    {
//        private string salario, nome;
//    }
//}

//exercicío 2
//class program
//{
//    static void Main(string[] args)
//    {
//        string nome, salario;
//        Console.Write("entre com o seu nome: ");
//            nome = Console.ReadLine();

//        Console.Write("entre com o seu salário: ");
//        salario = Console.ReadLine();

//        funcionario funcionario = new funcionario(nome, salario);
//    }
//    class funcionario
//    {
//        private string salario, nome;

//        public funcionario(string nome, string salario)
//        {
//            this.salario = salario;
//            this.nome = nome;
//        }
//    }
//}

//exercício 3
class program
{
    class NotaFiscal
    {
        int num, quant, prec; string desc;
    }

    public NotaFiscal()
    {

    }

    static void Main(string[] args)
    {
        int num, prec, quant; string desc;

        Console.WriteLine("entre com o número do item: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("entre com o preço do item: ");
        prec = int.Parse(Console.ReadLine());
        Console.WriteLine("entre com a quantidade comprada do item: ");
        quant = int.Parse(Console.ReadLine());
        Console.WriteLine("entre com o preço unitário do item: ");
        desc = Console.ReadLine();


    }
}