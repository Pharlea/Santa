//toda vez que o c# encontra uma chamada para um módulo e ele congela o bloco da instrução e ao chegar ao fim do módulo ele volta ao bloco que o chamou
//quando você passa um argumento por referência, o endereço de memória é o passado; ao contrário do argumento por valor, que apenas o valor é mandado. ou seja com ref, as varáveis mesmo de blocos diferentes acabam por ser basicamente a mesma

//class program
//{
//    static void Fatorial(int x,ref int fat)
//    {
//        for (int i = x; i > 0; i--)
//        {
//            fat *= i;
//        }
//        //return (fat);
//    }


//    static void Main(string[] args)
//    {
//        Console.Write("digite um número para cálculo do fatorial: ");
//        int num = int.Parse(Console.ReadLine());

//        int fat = 1;
//        Fatorial(num,ref fat);
//        Console.WriteLine(fat);
//    }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        float num = 10;
//        mostravalor(ref num);
//        Console.WriteLine(num);
//    }

//    static void mostravalor(ref float num)
//    {
//        num = (float)Math.Pow(num,2);
//    }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        float Tf = 0;
//        Console.Write("entre com a temperatura em celcius: ");
//        float Tc = float.Parse(Console.ReadLine());
//        calculoTf(Tc, ref Tf);

//        Console.WriteLine("a temperatura em Fahrenheit é igual a {0}", Tf);
//    }

//    static void calculoTf(float Tc, ref float Tf)
//    {
//        Tf = (float)(Tc * 1.8) + 32;
//    }
//}

class program
{
    static void Main(string[] args)
    {
        Console.Write("entre com o número: ");
        int num = int.Parse(Console.ReadLine());
        calculos(num*2);
    }
    
    static void calculos(int num)
    {
        int n; float quad = 0, cub = 0;

        for (int i = 0; i < num; i++)
        {
            n = i;
            quad = n * n;
            cub = n * n * n;
            Console.WriteLine("{0} {1} {2}", n, quad, cub);
            Console.WriteLine("{0} {1} {2}", n, quad + 1, cub + 1);
        }
            
    }
}

