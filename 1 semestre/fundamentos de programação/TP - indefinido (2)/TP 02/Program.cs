//// exercício 1
//float V1, V2;
//// V1 = primeiro valor e V2 = segundo valor
//Console.Write("entre com o primeiro valor: ");
//V1 = float.Parse(Console.ReadLine());
//Console.Write("entre com o segundo valor: ");
//V2 = float.Parse(Console.ReadLine());

//if (V1 == V2)
//{
//    Console.WriteLine("os valores não podem ser iguais");
//}
//else
//{
//    if (V1 > V2)
//    {
//        Console.WriteLine(("o maior dentre os dois valores é {0}"), V1);
//    }
//    else
//    {
//        Console.WriteLine(("o maior dentre os dois valores é {0}"), V2);
//    }
//}

////exercício 2
//float V1, V2;
//// V1 = primeiro valor e V2 = segundo valor 
//Console.Write("entre com o primeiro valor: ");
//V1 = float.Parse(Console.ReadLine());
//Console.Write("entre com o segundo valor: ");
//V2 = float.Parse(Console.ReadLine());

//if (V1 == V2)
//{
//    Console.WriteLine("os valores não podem ser iguais");
//}
//else
//{
//    if (V1 < V2)
//    {
//        Console.WriteLine(("o menor dentre os dois valores é {0}"), V1);
//    }
//    else
//    {
//        Console.WriteLine(("o menor dentre os dois valores é {0}"), V2);
//    }
//}

////exercício 3
//float V1, V2;
//// V1 = primeiro valor e V2 = segundo valor
//Console.Write("entre com o primeiro valor: ");
//V1 = float.Parse(Console.ReadLine());
//Console.Write("entre com o segundo valor: ");
//V2 = float.Parse(Console.ReadLine());

//if (V1 == V2)
//{
//    Console.WriteLine("os números são identicos");
//}
//else
//{
//    if (V1 > V2)
//    {
//        Console.WriteLine(("o maior dentre os dois valores é {0}"), V1);
//    }
//    else
//    {
//        Console.WriteLine(("o maior dentre os dois valores é {0}"), V2);
//    }
//}

////exercício 4
//float V1, V2, V3;
//// V1 = primeiro valor, V2 = segundo valor, V3 = terceiro valor
//Console.Write("entre com o primeiro valor: ");
//V1 = float.Parse(Console.ReadLine());
//Console.Write("entre com o segundo valor: ");
//V2 = float.Parse(Console.ReadLine());
//Console.Write("entre com o terceiro valor: ");
//V3 = float.Parse(Console.ReadLine());

//if (V1 > V2 && V1 > V3)
//{
//    Console.WriteLine("o maior número é o {0}", V1);
//}
//else if (V2 > V3)
//{
//    Console.WriteLine("o maior número é o {0}", V2);
//}
//else
//{
//    Console.WriteLine("o maior número é o {0}", V3);
//}

////exercício 5
//float lado1, lado2, lado3;
//Console.Write("digite o primeiro lado:");
//lado1 = float.Parse(Console.ReadLine());
//Console.Write("digite o segundo lado:");
//lado2 = float.Parse(Console.ReadLine());
//Console.Write("digite o terceiro lado:");
//lado3 = float.Parse(Console.ReadLine());

//if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2)
//{
//    if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
//    {
//        Console.WriteLine("o triângulo é escaleno");
//    }
//    else
//    {
//        if ((lado3 != lado2) && (lado1 == lado2 || lado1 == (lado3)))
//            {
//            Console.WriteLine("o triângulo é isórceles");
//        }
//        else
//        {
//            Console.WriteLine("o triângulo é equilátero");
//        }
//    }
//}
//else
//    Console.WriteLine("com esses valores não é possível formar um triângulo");
