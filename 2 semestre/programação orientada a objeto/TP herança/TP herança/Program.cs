//exercício 1

//class program
//{
//    public class ingresso
//    {
//        public float Valor = 1000;

//        public void ImprimeValor()
//        {
//            Console.WriteLine("o ingresso custa {0}R$", Valor);
//        }
//    }

//    public class normal : ingresso
//    {
//        public void Mostraingresso()
//        {
//            Console.WriteLine("\ningresso normal");
//        }
//    }

//    public class VIP : ingresso
//    {
//        public VIP()
//        {
//            Valor += 500;
//        }
//    }

//    public class camaroteinferior : VIP
//    {
//        public string local { get; set; }

//        public void Mostralocal()
//        {
//            Console.WriteLine(local);
//        }
//    }

//    public class camarotesuperior : VIP
//    {
//        public float adicional { get; set; }
//        public string local = "\ncamarote superior";

//        public void Mostralocal()
//        {
//            Console.WriteLine(local);
//        }
//    }

//    static void Main(string[] args)
//    {
//        camarotesuperior camarotesuperior = new camarotesuperior();
//        camaroteinferior camaroteinferior = new camaroteinferior();
//        normal normal = new normal();

//        camarotesuperior.adicional = 500;
//        camarotesuperior.Valor += camarotesuperior.adicional;


//        normal.Mostraingresso();
//        normal.ImprimeValor();

//        camaroteinferior.Mostralocal();
//        camaroteinferior.ImprimeValor();

//        camarotesuperior.Mostralocal();
//        camarotesuperior.ImprimeValor();
//    }
//}

//exercício 2

class program
{
    public class imovel
    {
        public float preco { get; set; }
        public string endereco = "ana costa, 100";

        public void Mostraendereco()
        {
            Console.WriteLine("endereço: ", endereco);
        }
    }
    public class Novo : imovel
    {
        public void Mostrapreco()
        {
            Console.WriteLine("preço: {0}", preco);
        }
        public void calculapreco()
        {
            preco += (float)(preco * 0.1);
        }
    }

    public class velho : imovel
    {
        public void calculapreco()
        {
            preco -= (float)(preco * 0.1);
        }

        public void Mostrapreco()
        {
            Console.WriteLine("preço: {0}", preco);
        }
    }
    static void Main(string[] args)
    {
        Novo novo = new Novo();
        velho velho = new velho();
        float temp;
        int opcao;

        Console.Write("1 - novo\n2 - velho\nentre com a sua opção: ");
        do
        {
            int.TryParse(Console.ReadLine(), out opcao);
            if (opcao != 1 && opcao != 2)
            {
                Console.Write("número inválido, tente novamente: ");
            }

        } while (opcao != 1 && opcao != 2);

        if (opcao == 1)
        {

            do
            {
                Console.Write("entre com o preço do imóvel: ");
                float.TryParse(Console.ReadLine(), out temp);
                novo.preco = temp;
            } while (novo.preco <= 0);

            novo.calculapreco();
            novo.Mostrapreco();
        }
        else
        {

            do
            {
                Console.Write("entre com o preço do imóvel: ");
                float.TryParse(Console.ReadLine(), out temp);
                velho.preco = temp;
            } while (velho.preco <= 1);

            velho.calculapreco();
            velho.Mostrapreco();
        }
    }
}
