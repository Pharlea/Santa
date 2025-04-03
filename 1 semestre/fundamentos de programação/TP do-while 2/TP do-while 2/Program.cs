////exercício 1
//int cont = 1, mult;
//do
//{
//    cont++;
//    mult = cont * 7;
//   if (mult < 100)
//    {
//        Console.WriteLine(mult);
//    }
//} while (mult < 100);

////exercício 2
//int cont = 0, decont = 4; float acum = 0, N;
//do
//{
//    cont++;
//    Console.Write("digite o número: ");
//    N = float.Parse(Console.ReadLine());
//    acum += N;
//    if (decont == 0)
//    {
//        Console.WriteLine(acum);
//        decont = 5;
//    }
//    decont--;
//} while (cont < 50); 

////exercício 3
//float N; int cont = 0, acum = 0;

//do
//{
//    do
//    {
//        Console.Write("entre com o número: ");
//        N = float.Parse(Console.ReadLine());
//    } while ((int)N != N);
//} while (N <= 0); 

//acum = (int)N;

//do
//{
//    acum += cont;
//    cont++;
//} while (cont < N);

//Console.WriteLine(acum);

////exercício 4
//float N; int cont = 1, pri = 0, seg = 0, ter = 0, qua = 0;
//do
//{
//    do
//    {
//        Console.Write("entre com o {0}° número: ", cont);
//        N = float.Parse(Console.ReadLine());
//    } while (N > 100 || N <= 0);
//    cont++;
//    if (N > 75)
//    {
//        qua++;
//    }
//    else
//    {
//        if (N > 50)
//        {
//            ter++;
//        }
//        else
//        {
//            if (N > 25)
//                {
//                seg++;
//            }
//            else
//            {
//                pri++;
//            }
//        }
//    }
//} while (cont <= 10);

//Console.WriteLine("intervalo [0 - 25]: {0}", pri);
//Console.WriteLine("intervalo [25 - 50]: {0}", seg);
//Console.WriteLine("intervalo [51 - 75]: {0}", ter);
//Console.WriteLine("intervalo [76 - 100]: {0}", qua);

////exercício 5
//int cont = 0; float num = 1, den = 2, res = 0;

//do
//{
//    cont++;
//    res += num / den;
//    num++; den++;
//} while (cont < 20);

//Console.WriteLine(res);

//exercício 6
int cont = 0, ncont = 0;float div = 1, N = 1, resto = -1;

do
{
    N++;
    do
    {
        div++;
            resto = N / div;
            resto = resto - (int)resto;
        if (resto != 0)
        {
            ncont++;
        }
    } while (resto == 0);
    if (ncont == 0)
    {
        cont++;
    }
    ncont = 0;
    div = 1;
    Console.WriteLine(N);
} while (cont < 20);
