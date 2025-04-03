////exercício 1
//float[] a = new float[10]; bool[] boolean = new bool[10];

//for (int i = 0; i < a.Length; i++)
//{
//    Console.Write("entre com o {0}° número: ", i + 1);
//    a[i] = float.Parse(Console.ReadLine());
//    boolean[i] = a[i] > 0;
//}

//for (int i = 0;i < a.Length; i++)
//{
//    Console.WriteLine("{0}° valor: {1}", i + 1, boolean[i]);
//}

////exercício 2
//int[] a = new int[5] {1, 20, 12, 1, 6}; int c = 0, som = 0, med;

//for (int i = 0; i < a.Length; i++)
//{
//    c++;
//}

//for (int i = 0;i < a.Length; i++)
//{
//    som += a[i];
//}

//med = som / c;

//Console.WriteLine("a média dos valores é igual a {0}", med);

////exercício 3
//string[] nome = new string[5]; float[] preco = new float[5]; int np = 0; float med, som = 0, cmed = 0;

//for (int i = 0; i < preco.Length; i++)
//{
//    Console.Write("qual o nome do seu produto? ");
//    nome[i] = Console.ReadLine();
//    Console.Write("qual o preço do seu produto em R$? ");
//    preco[i] = float.Parse(Console.ReadLine());
//    if (preco[i] < 50)
//    {
//        np++;
//    }
//    if (preco[i] > 100)
//    {
//        cmed++;
//        som += preco[i];
//    }
//}

//med = som / cmed;

//if (np != 0)
//{
//    Console.WriteLine("A quantidade de produtos com preço inferior a R$ 50,00 é {0}", np);
//}
//else
//{
//    Console.WriteLine("não há produtos com o preço inferior a R$ 50,00");
//}

//for (int i = 0;i < preco.Length;i++)
//{
//    if (preco[i] >= 50 && preco[i] <= 100)
//    {
//        Console.WriteLine("o produto {0} está entre as faixas de valor R$ 50,00 e R$ 100,00", nome[i]);
//    }
//}

//if (med > 0)
//{
//    Console.WriteLine("a média dos valores acima de R$ 100,00 é {0}", med);
//}
//else
//{
//    Console.WriteLine("não há valores acima de R$ 100,00");
//}

////exercício 4
//float[] vet1 = new float[5]; float[] vet2 = new float[vet1.Length];

//for (int i = 0; i < vet1.Length; i++)
//{
//    Console.Write("entre com o {0}° valor: ", 1 + i);
//    vet1[i] = float.Parse(Console.ReadLine());
//    vet2[i] = vet1[i];
//}

//for (int i = 0;i < vet2.Length;i++)
//{
//    Console.WriteLine(vet1[i]);
//}
//for (int i = 0;i < vet1.Length ; i++)
//{
//    Console.WriteLine(vet2[i]);
//}

////exercício 5
//float[] val = new float[10]; int refe, refemen = 0, refeig = 0;

//for (int i = 0; i < val.Length; i++)
//{
//    Console.Write("entre com o {0}° valor: ", i + 1);
//    val[i] = float.Parse(Console.ReadLine());
//}

//do
//{
//    Console.Write("entre com o valor de referência inteiro: ");
//    refe = int.Parse(Console.ReadLine());
//} while ((int)refe != refe);


//Console.WriteLine("os números maiores que o valor de referência são: ");
//for (int i = 0;i < val.Length; i++)
//{
//    if (val[i] > refe)
//    {
//        Console.WriteLine(val[i]);
//    }
//    else
//    {
//        if (val[i] < refe)
//                {
//            refemen++;
//        }
//        else
//        {
//            refeig++;
//        }
//    }
//}


//Console.WriteLine("a quantidade de números menor que o valor valor de referência é igual a {0}", refemen);
//Console.WriteLine("a quantidade de números igual ao valor valor de referência é de {0}", refeig);

