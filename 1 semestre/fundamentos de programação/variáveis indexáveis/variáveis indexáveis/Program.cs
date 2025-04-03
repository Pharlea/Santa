//new = alocação dinamica de memória 
// sempre que utilizar: [nomedoarray].length, será o equivalente ao  tamanho do array

//string[] prof = new string[6] 
//{ "José", "João", "Joana", "Maria", "Fernando", "Katia" }; 
//for (int i = 0; i < prof.Length; i++) 
//{ 
//    Console.WriteLine("{0}", prof[i]); 
//}




//double soma = 0; int i; double[] valor = new double[10];             
//// Entrada de dados no vetor
//for (i = 0; i < valor.Length; i++)             
//{                 
//    Console.Write("{0}º valor :", i + 1);                 
//    valor[i] = double.Parse(Console.ReadLine());             
//}              Console.Clear();             
//// Varrer o vetor e calcular a soma
//for (i = 0; i < valor.Length; i++)             
//{                 
//    Console.WriteLine("{0}º valor : {1}", i + 1, valor[i]);                 
//    soma += valor[i];             }              
//// Exibir a soma dos valores
//Console.WriteLine("Soma dos valores : {0:f1}", soma); 
//Console.ReadKey(); 








//int i; int[] x = new int[10];             
//// Entrada de dados
//for (i = 0; i < x.Length; i++)
//{                 
//    Console.Write("{0}º valor : ", i + 1);                 
//    x[i] = int.Parse(Console.ReadLine());             
//}              
//// Exibir em ordem inversa a da digitação
//for (i = x.Length - 1; i >= 0; i--)                 
//    Console.WriteLine("{0}º valor : {1}", i + 1, x[i]);             
//Console.ReadKey(); 







//int i, maior; int[] x = new int[10];              
//// Entrada de dados
//for (i = 0; i < x.Length; i++)             
//{                 
//    Console.Write("{0}º valor : ", i + 1);                 
//    x[i] = int.Parse(Console.ReadLine());             
//}              
//// Achar e exibir o maior valor
//maior = x[0];             
//for (i = 1; i < x.Length; i++) 
//{ 
//    if (x[i] > maior) 
//    { 
//        maior = x[i]; 
//    } 
//}
//Console.WriteLine("Maior valor : {0}", maior); 
//Console.ReadKey();













int i, k; int[] x = new int[20];              
// Entrada de dados
for (i = 0; i < x.Length; i++)             
{                 
    Console.Write("{0}º valor:", i + 1);                 
    x[i] = int.Parse(Console.ReadLine());             
}              
// valor da constante multiplicativa
Console.Write("Valor da constante : ");              
k = int.Parse(Console.ReadLine());              
// Multiplicar o vetor pela constante
for (i = 0; i < x.Length; i++)              
{                 
    x[i] = x[i] * k;                 
    Console.WriteLine("{0}º valor: {1}", i + 1, x[i]);             
}              
Console.ReadKey(); 