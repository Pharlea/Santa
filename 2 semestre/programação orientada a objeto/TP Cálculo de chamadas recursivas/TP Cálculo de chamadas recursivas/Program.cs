class Program 
{     static void Main(string[] args) 
    { 
        int n, cont = 0; 
        Console.Write("Digite um numero: ");
        n = int.Parse(Console.ReadLine());
        DateTime dt = DateTime.Now;
        
        for (int i = 0; i < n - 1; i++)
        {           
            dt = DateTime.Now;
            Console.Write("horário: " + dt.ToString());
            Console.WriteLine(" na sequência {0}, o número de vezes que a bateria foi acessada é igual a {1}", fib(n -i - 1, ref cont), cont);
            cont = 0;
        }
    }
    static int fib(int n, ref int cont)
    {
        cont++;
        if (n <= 1) return 1;
        return (fib(n - 1, ref cont) + fib(n - 2, ref cont));
    }
} 



