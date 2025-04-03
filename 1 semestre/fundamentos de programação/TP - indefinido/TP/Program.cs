////exercício 1
//float N;
//N = 0;

//while (N <=0)
//{
//    Console.Write("escreva um número positivo: ");
//    N = float.Parse(Console.ReadLine());
//}
//Console.WriteLine("Ok");

////exercício 2
//float n1, n2 = 0;

//Console.Write("digite o primeiro valor: ");
//n1 = float.Parse(Console.ReadLine());
//Console.Write("digite o segundo valor: ");
//n2 = float.Parse(Console.ReadLine());

//while (n1 >= n2)
//{
//    Console.Write("digite o segundo valor: ");
//    n2 = float.Parse(Console.ReadLine());
//}
//Console.WriteLine("Ok");

////exercício 3
//char s;
//Console.Write("Sexo:");
//s = Console.ReadKey().KeyChar;

//while (s != 'M' && s != 'F')
//{
//    Console.SetCursorPosition(5, 0);
//    s = Console.ReadKey().KeyChar;
//}
//Console.WriteLine("\nOK");

////exercício 4
//int n = 1;

//while (n <= 10)
//{
//    Console.WriteLine(n * 7);
//    n++;
//}

////exercício 5
//float N; int mult;
//mult = 1;
//Console.Write("entre com o valor do número: ");
//N = float.Parse(Console.ReadLine());

//while (N <= 0)
//{
//    Console.Write("entre com o valor do número: ");
//    N = float.Parse(Console.ReadLine());
//}


//    while (mult < 11)
//    {
//        Console.WriteLine(N * mult);
//        mult++;
//    }

////exercício 6
//float x, a, b;

//Console.Write("entre com o valor de x: ");
//x = float.Parse(Console.ReadLine());
//while (x <= 0)
//{
//    Console.Write("entre com o valor de x: ");
//    x = float.Parse(Console.ReadLine());
//}
//Console.Write("entre com o valor de a: ");
//a = float.Parse(Console.ReadLine());
//Console.Write("entre com o valor de b: ");
//b= float.Parse(Console.ReadLine());

//while (a >= b)
//{
//    Console.Write("entre com o valor de b: ");
//    b = float.Parse(Console.ReadLine());
//}
//while (a <= b)
//{
//    Console.WriteLine(x * b);
//        b--;
//}

////exercício 7
//int n = 1, mult = 1;

//while (n < 21)
//{
//    while (mult <= 10)
//    {
//        Console.WriteLine(n * mult);
//        mult++;
//    }
//    n++;
//    mult = 1;
//    Console.WriteLine("pressione qualquer tela");
//    Console.ReadKey();
//}

////exercício 8 
//int n = 0, soma;
//soma = 0;

//while (n <= 100)
//{
//    soma = soma + n++;
//}
//Console.WriteLine(soma);

////exercício 9
//float menor, Ns, maior, a;

//Ns = 1;
//Console.Write("\nescreva o {0}º valor: ", Ns);
//menor = maior = float.Parse(Console.ReadLine());
//while (Ns < 10)
//{
//    Ns++;
//    Console.Write("\nescreva o {0}º valor: ", Ns);
//    a = float.Parse(Console.ReadLine());
//    if (a < menor)
//    {
//        menor = a;
//    }
//    if (a > maior)
//    {
//        maior = a;
//    }
//}
//Console.WriteLine("o maior número é {0} e o menor é {1}", maior, menor);

