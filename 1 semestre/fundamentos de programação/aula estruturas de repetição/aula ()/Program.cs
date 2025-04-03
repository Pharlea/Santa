//estruturas de repetição (laço ou loop) 
// colocar dentro do laço apenas intruções que precisem ser repitidas / se preocupar com a condição, caso contrario o laço pode não iniciar ou não acabar  


//int contador = 1; 
//while (contador < 10)
//{
//    int numero = 7;
//    contador++;
//    numero = contador * numero;
//    Console.WriteLine("Contador = {0}", numero);
//}

//int contador = 1;
//while (contador <=10)
//{
//    Console.WriteLine("Contador = {0}", contador * 7);
//    contador++;
//}

//int x = 0;
//while (x <= 0)
//{
//    Console.Write("Valor positivo: ");
//    x = int.Parse(Console.ReadLine());
//}
//Console.Write("OK");
//Console.ReadKey();

//int a, b;
//Console.Write("1º valor :");
//a = int.Parse(Console.ReadLine());
//Console.Write("2º valor :");
//b = int.Parse(Console.ReadLine());
//while (b <= a)
//{
//    Console.Write("2º valor :");
//    b = int.Parse(Console.ReadLine());
//}
//Console.Write("OK");

char s;
Console.Write("Sexo:");
s = Console.ReadKey().KeyChar; // essa opção não espera pelo enter
// no caso ao lado o enter é necessário s= char.parse(console.readline());
               
while (s != 'M' && s != 'F')
{
    Console.SetCursorPosition(5, 0); //nesse caso ele decide onde o cursor do para
    s = Console.ReadKey().KeyChar;
}
Console.Write("\nOK");

