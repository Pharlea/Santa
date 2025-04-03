////exercício 1
//int N; float res = 0, num = 1, den;
//do
//{
//    Console.Write("digite a quantidade de somas: ");
//    N = int.Parse(Console.ReadLine());
//} while (N <= 0 || N > 20);


//for (N = N; N >= 1; N--)
//{
//    den = num + 1;
//    res += (num / den);
//    num++;
//}
//Console.WriteLine(res);

////exercício 2 
//float N, res = 0, num = 2 , den = 1;

//do
//{
//    Console.Write("entre com o número de somas ");
//    N = int.Parse(Console.ReadLine());
//} while (N <= 0 || N > 50);

//for (N = N; N >= 1; N--)
//{
//    num = (int)Math.Pow(2, N) + 1;
//    den = (int)Math.Pow(3, N);
//    res += (num / den);
//}
//Console.WriteLine(res);

////exercício 3 
//int f; float s, i, medS = 0, medF = 0, maior = -1, porc = 0;

//for (i = 1; i <= 500; i++)
//{
//    do
//    {
//        Console.Write("digite seu número de filho(a)s: ");
//        f = int.Parse(Console.ReadLine());
//    } while (f < 0);
//    do
//    {
//        Console.Write("digite seu salário: ");
//        s = int.Parse(Console.ReadLine());
//    } while (s < 0);
//    medS += s;
//    medF += f;
//    if (maior < s)
//    {
//        maior = s;
//    }
//    if (s > 1000)
//    {
//        porc++;
//    }
//}
//medF = medF / (i - 1);
//medS = medS / (i - 1);
//porc = porc / (i - 1);

//Console.WriteLine("\n a média do salário é {0:f2}", medS);
//Console.WriteLine("a média de filhos é " + medF);
//Console.WriteLine("a maior salário é {0:f2}", maior);
//Console.WriteLine("a porcentagem de pessoas que possuem um salário maior que 1000 é igual a {0}%", porc * 100);

////exercício 4 (incompleto)
//double pag, pre, tro; int r1 = 0, r05 = 0, r025 = 0, r01 = 0, r005 = 0, r001 = 0;

//Console.Write("por favor digite o preço da compra: ");
//pre = float.Parse(Console.ReadLine());
//Console.Write("por favor digite o valor a ser pago: ");
//pag = float.Parse(Console.ReadLine());

//tro = pre - pag;

//while (tro != 0) 
//{
//    if (tro >= 1)
//    {
//        tro = tro - 1;
//        r1++;
//    }
//    else
//    {
//        if (tro >= 0.5)
//        {
//            tro = tro - 0.5;
//            r05++;
//        }
//        else
//        {
//            if (tro >= 0.25)
//            {
//                tro = tro - 0.25;
//                r025++;
//            }
//            else
//            {
//                if (tro >= 0.1)
//                {
//                    tro = tro - 0.1;
//                    r01++;
//                }
//                else   
//                {
//                    if (tro >= 0.05)
//                    {
//                        tro = tro - 0.05;
//                        r005++;
//                    }
//                    else
//                    {
//                        if (tro >= 0.01)
//                        {
//                            tro = tro - 0.01;
//                            r001++;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
//Console.WriteLine("há {5} moedas de 1 real, {0} moedas de 50 centavos, {1} moedas de 25 centavos, {2} moedas de 10 centavos, {3} moedas de 5 centavos, {4} moedas de 1 centavo", r05, r025, r01, r005, r001, r1);

////exercício 5 (incompleto)
//float apli;

//Console.Write("digite o valor da aplicação: ");
//apli = float.Parse(Console.ReadLine());

//for (int i = 0; i <= 11; i++)
//{
//    apli = apli + (float)(apli * 0.05);
//}
//Console.WriteLine(apli);