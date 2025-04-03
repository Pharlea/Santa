////exercicío 1
//double val1, val2, val3, hipo;
//Console.Write("digite o primeiro valor ao lado:");
//val1 = double.Parse(Console.ReadLine());
//Console.Write("digite o segundo valor ao lado:");
//val2 = double.Parse(Console.ReadLine());
//Console.Write("digite o terceiro valor ao lado:");
//val3 = double.Parse(Console.ReadLine());

//if (val1 > val2 && val1 > val3)
//{
//    hipo = val1;
//    if (hipo * hipo == val2 * val2 + val3 * val3) 
//    {
//        Console.WriteLine("forma triângulo retângulo");
//    }
//    else
//    {
//        Console.WriteLine("não é possível formar um triângulo retângulo");
//    }

//}
//else if (val2 > val3 && val2 > val1)
//{
//    hipo = val2;
//    if (hipo * hipo == (val1 * val1 + val3 * val3))
//    {
//        Console.WriteLine("forma triângulo retângulo");
//    }
//    else
//        Console.WriteLine("não é possível formar triângulo retângulo");
//}
//else
//{
//    hipo = val3;
//    if (hipo * hipo == (val2 * val2 + val1 * val1))
//    {
//        Console.WriteLine("forma triângulo retângulo");
//    }
//    else
//    {
//        Console.WriteLine("não é possível formar triângulo retângulo");
//    }
//}

//// hipo = hipotenusa, val = valor

////exercício 2
//float p1, p2;
//Console.Write("digite o valor da p1: ");
//p1 = float.Parse(Console.ReadLine());
//p2 = (15 - p1)/2;
//Console.WriteLine("a nota necessária na p2 será de {0}", p2); 


//exercício 3
char sexo; float peso, altura, rela;

Console.Write("entre com seu sexo:");
sexo = char.Parse(Console.ReadLine());
Console.Write("entre com seu peso:");
peso = float.Parse(Console.ReadLine());
Console.Write("entre com sua altura:");
altura = float.Parse(Console.ReadLine());

rela = peso / (altura * altura);

if (sexo == 'f' || sexo == 'F')
{
    if (rela < 19)
    {
        Console.WriteLine("abaixo do peso");
    }
    else
    {
        if ((rela >= 24))
        {
            Console.WriteLine("acima do peso");
        }
        else
        {
            Console.WriteLine("peso ideal");
        }
    }
}
else
{
    if (sexo == 'm' || sexo == 'M')
    {
        if (rela < 20)
        {
            Console.WriteLine("abaixo do peso");
        }
        else
        {
            if ((rela >= 25))
            {
                Console.WriteLine("acima do peso");
            }
            else
            {
                Console.WriteLine("peso ideal");
            }
        }
    }
}

if ((sexo != 'f' && sexo != 'F' && sexo != 'm' && (sexo != 'M')))
{
    Console.WriteLine("sexo inválido");
}
//rela = relação

////exercício 4
//float acc, vi, t, vf;

//Console.Write("digite o valor da velocidade inicial: ");
//vi = float.Parse(Console.ReadLine());
//Console.Write("digite o valor da aceleração: ");
//acc = float.Parse(Console.ReadLine());
//Console.Write("digite o valor do tempo de percurso: ");
//t = float.Parse(Console.ReadLine());

//vf = vi + acc * t;
//vf = (float)(vf * 3.6);

//if (vf <= 40)
//{
//    Console.WriteLine("veículo muito lento");
//}
//else
//{
//    if (vf <= 60)
//    {
//        Console.WriteLine("velocidade permitida");
//    }
//    else
//    {
//        if (vf <= 80)
//        {
//            Console.WriteLine("velocidade de cruzeiro");
//        }
//        else
//        {
//            if (vf <= 120)
//            {
//                Console.WriteLine("veículo rápido");
//            }
//            else
//            {
//                Console.WriteLine("veículo muito rápido");
//            }
//        }
//    }
//}

////t = tempo, vi = velocidade inicial, acc = aceleração, vf = velocidade final