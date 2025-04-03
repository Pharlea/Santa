//exercício 1

class program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("entre com o número: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("a soma de todos os números entre 1 e o número digitado é igual a {0}", soma(0, num));
    }

    static int soma(int res, int n)
    {
        if (n == 0)
        {
            return res;
        }
        res += n;
        return (soma(res, n - 1));
    }
}

//exercício 2

//class program
//{
//    static void Main (string[] args)
//    {
//        int[] num = new int[5];
//        num[0] = 2;
//        num[1] = 7;
//        num[2] = 14;
//        num[3] = 4;
//        num[4] = 1;

//        Console.WriteLine ("o maior número do array é {0}", maior(num.Length -1, num, 0));
//    }

//    static int maior (int tam, int[] n, int maiorr)
//    {
//        if (tam == 0)
//        {
//            return maiorr;
//        }
//        if (n[tam] > maiorr)
//        {
//            maiorr = n[tam];
//        }
//        return maior(tam - 1, n, maiorr);
//    }
//}
