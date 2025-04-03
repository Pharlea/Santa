//exercício 1

//class program
//{
//    static void Main(string[] args)
//    {
//        int fat;
//        do
//        {
//            Console.Write("entre com o número positivo a ter o fatorial descoberto: ");
//            fat = int.Parse(Console.ReadLine());
//        } while (fat <= 0);
//        int prefat = fat;
//        fatorial(ref fat);

//        Console.WriteLine("{0}! é igual a {1}", prefat, fat);
//    }

//    static void fatorial(ref int fat)
//    {
//        int calfat = fat;
//        for (int i = 2; i < fat; i++)
//        {
//            calfat *= i;
//        }
//        fat = calfat;
//    }
//}

//exercício 2

//class program
//{
//    static void Main(string[] args)
//    {
//        int ano, mes, dia;
//        Console.Write("entre com a quantidade de anos que você viveu: ");
//        ano = int.Parse(Console.ReadLine());
//        Console.Write("\nentre com a quantidade de meses que você viveu: ");
//        mes = int.Parse(Console.ReadLine());
//        Console.Write("\nentre com a quantidade de dias que você viveu: ");
//        dia = int.Parse(Console.ReadLine());
//        caldias (ano, mes, dia);
//    }

//    static void caldias (int ano, int mes, int dia)
//    {
//        int dias;
//        dias = ano * 365; 
//        dias += (mes * 30);
//        dias += dia;
//        Console.WriteLine("você viveu por {0} dias", dias);
//    }
//}

//exercício 3

//class program
//{
//    static void Main(string[] args)
//    {
//        int op; float res;
//        do
//        {
//            Console.Write("digite 1 para adição, 2 para subtração, 3 para multiplicação ou 4 para divisão. ");
//            op = int.Parse(Console.ReadLine());
//        } while (op < 1 || op > 4);

//        if (op == 1) 
//        {
//            res = adicao(); 
//        }
//        else if (op == 2) 
//        { 
//            res = subtracao(); 
//        }
//        else if (op == 3) 
//        { 
//            res = multiplicacao(); 
//        }
//        else 
//        { 
//            res = divisao(); 
//        }
//        Console.WriteLine("o resultado da operação é igual a {0}",res);
//    }

//    static float adicao()
//    {
//        float soma = 0, entrada;
//        Console.Write("entre com os números a serem somados (ultilize 0 para finalizar a conta): ");
//        do
//        {
//            entrada = int.Parse(Console.ReadLine());
//            soma += entrada;
//        } while (entrada != 0);
//        return soma;
//    }
//    static float subtracao()
//    {
//        float sub, entrada;
//        Console.Write("entre com os números a serem subtraidos (ultilize 0 para finalizar a conta): ");
//        entrada = int.Parse(Console.ReadLine());
//        sub = entrada;
//        while (entrada != 0)
//        {
//            entrada = int.Parse(Console.ReadLine());
//            sub -= entrada;
//        }
//        return sub;
//    }
//    static float multiplicacao()
//    {
//        float mult = 1, entrada;
//        Console.Write("entre com os números a serem multiplicados (ultilize 0 para finalizar a conta): ");
//        entrada = float.Parse(Console.ReadLine());
//        while (entrada != 0)
//        {
//            mult *= entrada;
//            entrada = int.Parse(Console.ReadLine());
//        }
//        return mult;
//    }
//    static float divisao()
//    {
//        float div = 1, entrada;
//        Console.Write("entre com os números a serem divididos (ultilize 0 para finalizar a conta): ");
//        entrada = float.Parse(Console.ReadLine());
//        div = entrada;
//        while (entrada != 0)
//        {
//            entrada = int.Parse(Console.ReadLine());
//            if (entrada != 0)
//            {
//                div = div / entrada;
//            }
//        }
//        return div;
//    }
//}

//exercício 4

//class program
//{
//    static void Main(string[] args)
//    {
//        float num; string sinal;
//        Console.Write("entre com o número: ");
//        num = float.Parse(Console.ReadLine());
//        if (num == 0)
//        {
//            Console.WriteLine("0 não possui sinais");
//        }
//        else
//        {
//            sinal = verificasinal(num);


//            Console.WriteLine("o número é {0}", sinal);
//        }
//    }

//    static string verificasinal (float num)
//    {
//        string sinal;
//        num %= 2;
//        if (num != 0)
//        {
//            sinal = "impar";
//        }
//        else
//        {
//            sinal = "par";
//        }
//        return sinal;
//    }
//}

//exercício 5

//class program
//{
//    static void Main(string[] args)
//    {
//        int num; bool prim;
//        Console.Write("entre com o número: ");
//        num = int.Parse(Console.ReadLine());
//        prim = primV(num);
//        if (prim == true)
//        {
//            Console.WriteLine("o número {0} é primo", num);
//        }
//        else 
//        {
//            Console.WriteLine("o número {0} não é primo", num);
//         }
//    }

//    static bool primV (int num)
//    {
//        float rest; int cont = 0;
//        for (int i = 2; i <= num; i++)
//        {
//            rest = (float)num % i;
//            if (rest == 0)
//            {
//                cont++;
//            }
//        }
//        if (cont == 1)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}

