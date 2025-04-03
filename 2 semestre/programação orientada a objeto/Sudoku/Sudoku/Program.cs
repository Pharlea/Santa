using Microsoft.Win32.SafeHandles;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

class Sudoku
{
    private bool[] locke = new bool[81];
    private string[] tab = new string[81];
    private int[] vitLin = new int[9];
    public int rest = 81;
    private int pos, escolha, num, linha, coluna;
    private bool vit;

    public Sudoku() //inicializa a tabela com interrogações e as linhas com zeros
    {
        for (int i = 0; i < tab.Length; i++) { tab[i] = "?"; }
        for (int i = 0; i < vitLin.Length; i++) { vitLin[i] = 0; }
    }

    public void Tabuleiro() //mostra o tabuleiro na tela
    {
        Console.Clear();
        for (int i = 0; i < tab.Length; i++)
        {
            if (i == 0 || i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 54 ||i == 63 || i == 72)
            {
                Console.Write("\n|");
            }

            Console.Write(" {0} ", tab[i]);
            
            if (i == 2 || i == 5 || i == 8 || i == 11 || i == 14 || i == 17 || i == 20 || i == 23 || i == 26 || i == 29 || i == 32 || i == 35 || i == 38 || i == 41 || i == 44 || i == 47 || i == 50 || i == 53 || i == 56 || i == 59 || i == 62 || i == 65 || i == 68 || i == 71 || i == 74 || i == 77 || i == 80)
            {
                Console.Write("|");
            }
            if (i == 26 || i == 53) { Console.WriteLine(); }
        }
    }

    public void Dificuldade() //escolhe a dificuldade
    {
        do
        {
            Console.Write("1- fácil \n2- médio \n3- difícil \nescolha a dificuldade desejada: ");
            int.TryParse(Console.ReadLine(), out escolha);
            if (escolha < 1 || escolha > 3) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("número inválido"); Console.ResetColor(); }
        } while (escolha < 1 || escolha > 3);

        GravaJogoInicial();
    }

    public bool ganhou() //verifica se o jogador ganhou
    {
        int count = 0;
        for (int i = 0; i < vitLin.Length; i++)
        {
            if (vitLin[i] == 45)
            {
                count++;
            }
        }
        vit = count == vitLin.Length;
        return vit;
    }

    public void JogaJogo() //pega as linhas e as colunas (para conseguir a posição) e o número a ser gravado
    {

        Console.WriteLine("\n\n(entre com linha 0 e coluna 0 para desistir)");
        do
        {
            do
            {
                do
                {
                    Console.Write("\nlinha: ");
                    int.TryParse(Console.ReadLine(), out linha);
                    if (dezDigitos(linha)) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("linha inválida\n"); Console.ResetColor(); }
                } while (dezDigitos(linha));

                do
                {
                    Console.Write("coluna: ");
                    int.TryParse(Console.ReadLine(), out coluna);
                    if (dezDigitos(coluna)) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("coluna inválida\n"); Console.ResetColor(); }
                } while (dezDigitos(coluna));
                if (linha == 0 && coluna != 0 || linha != 0 && coluna == 0) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nposição inválida"); Console.ResetColor(); }

            } while (linha == 0 && coluna != 0 || linha != 0 && coluna == 0);

            Posicao(linha, coluna);

            if (desistiu() && locke[pos]) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("este espaço já foi escolhido!\n"); Console.ResetColor(); }

        } while (desistiu() && locke[pos]);

        if (desistiu())
        {
            do
            {
                Console.Write("número desejado: ");
                int.TryParse(Console.ReadLine(), out num);

                if (num > 9 || num < 1) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("número inválido"); Console.ResetColor(); }

            } while (num > 9 || num < 1);
        }

        GravaJogo();
    }

    private void GravaJogoInicial() //grava os primeiros números dependendo da dificuldade escolhida
    {
        switch (escolha)
        {
            case 1: num = 9; pos = 0; GravaJogo(); num = 5; pos = 1; GravaJogo(); num = 7; pos = 2; GravaJogo(); num = 8; pos = 4; GravaJogo(); num = 2; pos = 6; GravaJogo(); num = 4; pos = 7; GravaJogo(); num = 6; pos = 8; GravaJogo(); num = 3; pos = 11; GravaJogo(); num = 9; pos = 12; GravaJogo(); num = 2; pos = 13; GravaJogo(); num = 7; pos = 16; GravaJogo(); num = 1; pos = 17; GravaJogo(); num = 6; pos = 18; GravaJogo(); num = 4; pos = 21; GravaJogo(); num = 5; pos = 22; GravaJogo(); num = 9; pos = 24; GravaJogo(); num = 3; pos = 25; GravaJogo(); num = 8; pos = 26; GravaJogo(); num = 2; pos = 27; GravaJogo(); num = 7; pos = 28; GravaJogo(); num = 4; pos = 29; GravaJogo(); num = 5; pos = 30; GravaJogo(); num = 1; pos = 32; GravaJogo(); num = 6; pos = 34; GravaJogo(); num = 3; pos = 35; GravaJogo(); num = 3; pos = 36; GravaJogo(); num = 1; pos = 37; GravaJogo(); num = 6; pos = 38; GravaJogo(); num = 8; pos = 41; GravaJogo(); num = 5; pos = 44; GravaJogo(); num = 5; pos = 45; GravaJogo(); num = 9; pos = 46; GravaJogo(); num = 6; pos = 48; GravaJogo(); num = 4; pos = 50; GravaJogo(); num = 2; pos = 53; GravaJogo(); num = 1; pos = 54; GravaJogo(); num = 4; pos = 55; GravaJogo(); num = 2; pos = 56; GravaJogo(); num = 7; pos = 57; GravaJogo(); num = 6; pos = 58; GravaJogo(); num = 5; pos = 59; GravaJogo(); num = 3; pos = 60; GravaJogo(); num = 9; pos = 62; GravaJogo(); num = 8; pos = 63; GravaJogo(); num = 6; pos = 64; GravaJogo(); num = 5; pos = 65; GravaJogo(); num = 4; pos = 67; GravaJogo(); num = 9; pos = 68; GravaJogo(); num = 1; pos = 69; GravaJogo(); num = 2; pos = 70; GravaJogo(); num = 7; pos = 71; GravaJogo(); num = 7; pos = 72; GravaJogo(); num = 9; pos = 74; GravaJogo(); num = 8; pos = 75; GravaJogo(); num = 1; pos = 76; GravaJogo(); num = 6; pos = 78; GravaJogo(); num = 5; pos = 79; GravaJogo(); break;
            case 2: num = 1; pos = 0; GravaJogo(); num = 4; pos = 4; GravaJogo(); num = 2; pos = 6; GravaJogo(); num = 6; pos = 7; GravaJogo(); num = 5; pos = 12; GravaJogo(); num = 1; pos = 21; GravaJogo(); num = 4; pos = 24; GravaJogo(); num = 5; pos = 25; GravaJogo(); num = 7; pos = 26; GravaJogo(); num = 4; pos = 27; GravaJogo(); num = 3; pos = 28; GravaJogo(); num = 7; pos = 31; GravaJogo(); num = 8; pos = 32; GravaJogo(); num = 8; pos = 36; GravaJogo(); num = 9; pos = 46; GravaJogo(); num = 6; pos = 47; GravaJogo(); num = 2; pos = 48; GravaJogo(); num = 1; pos = 49; GravaJogo(); num = 3; pos = 50; GravaJogo(); num = 7; pos = 51; GravaJogo(); num = 4; pos = 52; GravaJogo(); num = 8; pos = 53; GravaJogo(); num = 7; pos = 56; GravaJogo(); num = 6; pos = 57; GravaJogo(); num = 1; pos = 59; GravaJogo(); num = 8; pos = 60; GravaJogo(); num = 4; pos = 62; GravaJogo(); num = 2; pos = 63; GravaJogo(); num = 1; pos = 64; GravaJogo(); num = 8; pos = 65; GravaJogo(); num = 4; pos = 68; GravaJogo(); num = 3; pos = 72; GravaJogo(); num = 6; pos = 73; GravaJogo(); num = 9; pos = 76; GravaJogo(); num = 5; pos = 80; GravaJogo(); break;
            case 3: num = 9; pos = 0; GravaJogo(); num = 7; pos = 4; GravaJogo(); num = 6; pos = 7; GravaJogo(); num = 4; pos = 11; GravaJogo(); num = 8; pos = 15; GravaJogo(); num = 7; pos = 17; GravaJogo(); num = 9; pos = 25; GravaJogo(); num = 7; pos = 28; GravaJogo(); num = 4; pos = 33; GravaJogo(); num = 2; pos = 34; GravaJogo(); num = 6; pos = 36; GravaJogo(); num = 5; pos = 37; GravaJogo(); num = 3; pos = 41; GravaJogo(); num = 9; pos = 44; GravaJogo(); num = 4; pos = 45; GravaJogo(); num = 8; pos = 48; GravaJogo(); num = 7; pos = 50; GravaJogo(); num = 5; pos = 51; GravaJogo(); num = 1; pos = 57; GravaJogo(); num = 9; pos = 59; GravaJogo(); num = 4; pos = 61; GravaJogo(); num = 3; pos = 63; GravaJogo(); num = 4; pos = 68; GravaJogo(); num = 2; pos = 69; GravaJogo(); num = 1; pos = 71; GravaJogo(); num = 5; pos = 77; GravaJogo(); break;
        }
    }

    private bool dezDigitos(int num) //verifica se um número está entre 0 e 9
    {
        return (num > 9 || num < 0);
    }

    private bool desistiu() //verifica se o jogador desistiu com base no valor da pos
    {
        return pos != -10;
    }

    private void contaEspaços() //diminui um do total de espaços restantes toda vez que é chamado
    {
        rest--;
    }

    private void GravaJogo() // diminui a quantidade de espaços restantes, chama o método Linhas, bloqueia a posição atual e coloca o número desejado na tabela
    {
        contaEspaços();
        Linhas();
        if (pos != -10) { locke[pos] = true; tab[pos] = num.ToString(); }
    }

    private void Linhas() //adiciona o número atual a sua respectiva linha
    {
        if (pos == -10) { rest = pos; }
        else if (pos < 9) { vitLin[0] += num; }
        else if (pos < 18) { vitLin[1] += num; }
        else if (pos < 27) { vitLin[2] += num; }
        else if (pos < 36) { vitLin[3] += num; }
        else if (pos < 45) { vitLin[4] += num; }
        else if (pos < 54) { vitLin[5] += num; }
        else if (pos < 63) { vitLin[6] += num; }
        else if (pos < 72) { vitLin[7] += num; }
        else { vitLin[8] += num; }
    }

    private void Posicao(int lin, int col) //descobre a posição com base na linha e na coluna atual
    {
        pos = (lin - 1) * 9 + (col - 1);
    }
}
class program
{
    static void Main(string[] args)
    {
        char repetir = 's';

        do
        {
            Sudoku sudoku = new Sudoku();
            sudoku.Dificuldade();

            do
            {
                sudoku.Tabuleiro();
                sudoku.JogaJogo();
            } while (sudoku.rest > 0);

            sudoku.Tabuleiro();

            if (sudoku.ganhou() == true)
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\nvocê ganhou! "); Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nvocê perdeu! "); Console.ResetColor();
            }

            do
            {
                Console.WriteLine("você deseja jogar novamente? (s/n)");
                char.TryParse(Console.ReadLine(), out repetir);
                repetir = char.ToLower(repetir);

                if (repetir != 's' && repetir != 'n')
                {
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\nresposta inválida"); Console.ResetColor();
                }
            } while (repetir != 's' && repetir != 'n');
            Console.Clear();
        } while (repetir == 's');
    }
}