//// Declaração de duas variáveis reais
//float x, resp;
//// Limpar a tela
//Console.Clear();
//// Exibir a mensagem para o usuário digitar um valor
//Console.Write("Digite um valor : ");
///* Aguardar a digitação de um valor
// Converter a string digitada para o tipo float
// Armazenar o valor escolhido na variável x
// */
//x = float.Parse(Console.ReadLine());
//resp = 2 * x;
//Console.Write("dobro de {2}: {0} {1}", resp,"obviamente", x);
//// Aguardar uma tecla, antes de encerrar o programa
//Console.ReadKey();


float anos, dias, horas;
Console.Clear();
Console.Write("Idade em anos : ");
anos = float.Parse(Console.ReadLine());

dias = anos * 365;
horas = dias * 24;
Console.WriteLine("{0} anos de vida", anos);
Console.WriteLine("Aproximadamente {0} dias", dias);
Console.WriteLine("{0} horas! ", horas);
Console.ReadKey();

