//o sistema operaciona reserva dois espaços de memória, um para os dados e outro para o código
//uma código/função/bloco recursivo é aquele código/função/bloco que chama a si mesmo
//toda função recursiva tem um ponto de parada
//toda função recursiva é um laço na memória RAM
//quando o bloco recursivo chama a si mesmo é chamado de recursividade direta; se o loop de blocos inclui mais de 1 bloco, é chamado de recursividade direta
//vantagens: códigos recursivos são curtos, permite escrever algoritimo de forma clara e concisa
//desvatagens: lentidão, pode ocorrer um estouro da pilha, redução de desempenho, dificuldade na depuração (principalmente se a recursão for muito profunda)
//tudo que eu faço com recursividade, eu faço sem ela
//de preferência, não usar recursividade (usá-la quando o problema pedir por ela (normalmente quando há problemas hierárquicos))
//recursividade de cauda é quando a última instrução é a chamada (return)

//class program
//{

//    static int fatorial(int x)
//    {
//        if (x == 1) return (1);
//        return (x * fatorial(x - 1));
//    }

//    static void Main(string[] args)
//    {
//        int num = 150;
//        Console.Write("A soma é {0}", fatorial(num));
//    }
//}

//class program
//{
//    static int fib(int n)
//    {
//        if (n <= 1) return 1;
//        return (fib(n - 1) + fib(n - 2));
//    }

//    static void Main(string[] args)
//    {
//        int n;
//        Console.Write("digite um número");
//        n = int.Parse(Console.ReadLine());
//        Console.WriteLine("com recursividade");
//        Console.WriteLine(fib(n));
//        Console.ReadKey();
//    }
//}

