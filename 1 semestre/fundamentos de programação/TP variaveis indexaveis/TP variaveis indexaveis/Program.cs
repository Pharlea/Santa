////exercício 1
//float[] N = new float[30]; float a = 1, b = 2;

//for (int i = 0; i < N.Length; i++)
//{
//    N[i] = a / b;
//    a++;
//    b++;
//}
//for (int i = 0;i < N.Length; i++)
//{
//    Console.WriteLine(N[i]);
//}

////exercício 2
//float[] v1 = new float[20]; float[] v2 = new float[20]; float con;

//for (int i = 0; i < 20; i++)
//{
//    Console.Write("entre com o {0}° valor: ", i + 1);
//    v1[i] = float.Parse(Console.ReadLine());
//}

//Console.Write("entre com a constante multiplicativa: ");
//con = float.Parse(Console.ReadLine());

//for (int i = 0;i < 20;i++)
//{
//    v2[i] = v1[i] * con;
//}

//for (int i = 0;i < 20; i++)
//{
//    Console.WriteLine("{0} multiplicado por {1} é igual a {2}", v1[i], con, v2[i]);
//}

////exercício 3
//int mult = 1; int[] n = new int[100];

//for (int i = 0; i < n.Length; i++)
//{
//    n[i] = mult*5;
//    mult++;
//}

//for (int i = 0;i < n.Length; i++)
//{
//    Console.WriteLine(n[i]);
//}

////exerecício 4
//float med = 0; float[] n = new float[100]; int nn = 0;

//for (int i = 0; i < n.Length; i++)
//{
//    do
//    {
//        Console.Write("digite o {0}° valor: ", i + 1);
//        n[i] = float.Parse(Console.ReadLine());
//    } while (n[i] < 0 || n[i] != (int)n[i]);
//    if (n[i]/2 != (int)n[i]/2)
//    {
//        med += n[i];
//        nn++;
//    }
//}

//if (med == 0)
//{
//    Console.WriteLine("não houve números negativos");
//}
//else
//{
//    med = med / nn;
//    Console.WriteLine("a média dos números digitados é igual a {0}", med);
//}

////exercício 5
//float[] n = new float[20]; int nv; float nb; bool haigual = false;

//do
//{
//    Console.Write("quantos valores você gostaria de armazenar? ");
//    nv = int.Parse(Console.ReadLine());
//    if (nv < 1 || nv > 20)
//    {
//        Console.WriteLine("o valor deve estar entre 1 e 20");
//    }
//} while (nv < 1 || nv > 20);

//for (int i = 0; i < nv; i++)
//{
//    Console.Write("entre com o {0}° valor: ", i + 1);
//    n[i] = int.Parse(Console.ReadLine());
//}

//Console.Write("entre com o número que você deseja que seja encontrado: ");
//nb = float.Parse(Console.ReadLine());

//for (int i = 0;i < nv; i++)
//{
//    if (n[i] == nb)
//    {
//        Console.WriteLine("o valor está na {0}° posição", i + 1);
//        haigual = true;
//    }
//}
//if (haigual == false)
//{
//    Console.WriteLine("Valor não encontrado!");
//}

////exercício 6
//string[] nome = new string[100]; char[] sexo = new char[100]; int[] idade = new int[100];

//for (int i = 0; i < nome.Length; i++)
//{
//    Console.Write("entre com o seu nome: ");
//    nome[i] = Console.ReadLine();
//    do
//    {
//        Console.Write("entre com o seu sexo: ");
//        sexo[i] = char.Parse(Console.ReadLine());
//    } while (sexo[i] != 70 && sexo[i] != 77);
//    do
//    {
//        Console.Write("entre com a sua idade: ");
//        idade[i] = int.Parse(Console.ReadLine());
//    } while (idade[i] <= 0);
//}

//for (int i = 0;i < nome.Length;i++)
//{
//    if (sexo[i] == 70)
//        {
//        Console.WriteLine("nome: {0} sexo: {1} idade: {2}", nome[i], sexo[i] ,idade[i]);
//    }
//}

////exercício 7
//string pal; int c = 0, igual = 0, c2;
//Console.Write("entre com a palavra: ");
//pal = Console.ReadLine();
//for (int i = 0; i < pal.Length; i++)
//{
// c++;
//}
//c2 = c;
//for (int i = 0;i < c; i++, c2--)
//{
// if (pal[i] == pal[c2 - 1])
// {
// igual++;
// }
//}
//if (igual == c)
//{
// Console.WriteLine("a palavra é um palíndromo");
//}
//else
//{
// Console.WriteLine("a palavra não é um palíndromo");
//}

////exercício 8
//float[] n = new float[20]; float tro; int c = 1;
//for (int i = 0; i < 20; i++)
//{
// Console.Write("entre com o {0}° valor: ", i + 1);
// n[i] = float.Parse(Console.ReadLine());
//}
//for (int i = 0;i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 1; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 2; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 3; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 4; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 5; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 6; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 7; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 8; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 9; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 10; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 11; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 12; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 13; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 14; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 15; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 16; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 17; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 18; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 19; i < n.Length - 1; i++)
//{
// if (n[i] > n[i + c] && i + c < 20)
// {
// tro = n[i];
// n[i] = n[i + c];
// n[i + c] = tro;
// }
//}
//for (int i = 0; i < n.Length; i++)
//{
// Console.WriteLine(n[i]);
//}

