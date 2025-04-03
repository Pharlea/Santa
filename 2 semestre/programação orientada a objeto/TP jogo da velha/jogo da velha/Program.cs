class Velha
{
    public bool[] locke = new bool[9]; public char[] tab = new char[9]; private int pos, vit; private int[] lin1 = new int[8], lin2 = new int[8]; public int rod = 0; private bool jogador;
    public string jogador1 { get; set; }
    public string jogador2 { get; set; }
    public int GetPos { get { return pos; } }

    public void Tabuleiro()
    {
        Console.Clear();
        Console.WriteLine("{0}|{1}|{2}\n{3}|{4}|{5}\n{6}|{7}|{8}", tab[0], tab[1], tab[2], tab[3], tab[4], tab[5], tab[6], tab[7], tab[8]);
    }

    public Velha()
    {
        for (int i = 0; i < tab.Length; i++) { tab[i] = '?'; }

        for (int i = 0; i < lin1.Length; i++) { lin1[i] = 0; lin2[i] = 0; }
    }

    public void JogaJogo()
    {
        int lin, col;
        do
        {
            do
            {
                Console.Write("linha: ");
                int.TryParse(Console.ReadLine(), out lin);
                Console.ForegroundColor = ConsoleColor.Red;
                if (lin > 3 || lin < 1) { Console.WriteLine("linha inválida\n"); }
                Console.ResetColor();
            } while (lin > 3 || lin < 1);

            do
            {
                Console.Write("coluna: ");
                int.TryParse(Console.ReadLine(), out col);

                Console.ForegroundColor = ConsoleColor.Red;
                if (col > 3 || col < 1) { Console.WriteLine("coluna inválida\n"); }
                Console.ResetColor();
            } while (col > 3 || col < 1);

            Posicao(lin, col);

            if (locke[pos] == true) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("este espaço já foi escolhido!\n"); Console.ResetColor(); };

        } while (locke[pos] == true);

        if (jogador == true) { tab[pos] = 'O'; locke[pos] = true; }
        else { tab[pos] = 'X'; locke[pos] = true; }
    }

    public void LinhasJ1()
    {
        jogador = !jogador;
        switch (pos)
        {
            case 0: lin1[0]++; lin1[3]++; lin1[6]++; break;
            case 1: lin1[0]++; lin1[4]++; break;
            case 2: lin1[0]++; lin1[5]++; lin1[7]++; break;
            case 3: lin1[1]++; lin1[3]++; break;
            case 4: lin1[1]++; lin1[4]++; lin1[6]++; lin1[7]++; break;
            case 5: lin1[1]++; lin1[5]++; break;
            case 6: lin1[2]++; lin1[3]++; lin1[7]++; break;
            case 7: lin1[2]++; lin1[4]++; break;
            case 8: lin1[2]++; lin1[5]++; lin1[6]++; break;
        }
    }

    public void LinhasJ2()
    {
        jogador = !jogador;
        switch (pos)
        {
            case 0: lin2[0]++; lin2[3]++; lin2[6]++; break;
            case 1: lin2[0]++; lin2[4]++; break;
            case 2: lin2[0]++; lin2[5]++; lin2[7]++; break;
            case 3: lin2[1]++; lin2[3]++; break;
            case 4: lin2[1]++; lin2[4]++; lin2[6]++; lin2[7]++; break;
            case 5: lin2[1]++; lin2[5]++; break;
            case 6: lin2[2]++; lin2[3]++; lin2[7]++; break;
            case 7: lin2[2]++; lin2[4]++; break;
            case 8: lin2[2]++; lin2[5]++; lin2[6]++; break;
        }
    }


    public int Qganhou()
    {

        if (lin1[0] == 3 || lin1[1] == 3 || lin1[2] == 3 || lin1[3] == 3 || lin1[4] == 3 || lin1[5] == 3 || lin1[6] == 3 || lin1[7] == 3) return 1;

        if (lin2[0] == 3 || lin2[1] == 3 || lin2[2] == 3 || lin2[3] == 3 || lin2[4] == 3 || lin2[5] == 3 || lin2[6] == 3 || lin2[7] == 3) return 2;

        if (rod == 5) return 0;

        else return -1;
    }

    public void MostraVencedor()
    {
        switch (Qganhou())
        {
            case 0: Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\ndeu Velha!"); Console.ResetColor(); break;
            case 1: Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\no(a) vencedor(a) é {0}!", jogador1); Console.ResetColor(); break;
            case 2: Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\no(a) vencedor(a) é {0}!", jogador2); Console.ResetColor(); break;
        }
    }

    public void Posicao(int lin, int col)
    {
        pos = (lin - 1) * 3 + (col - 1);
    }
}

class program
{
    static void Main(string[] args)
    {
        string jogador; Velha Velha = new Velha();

        do
        {
            Console.Write("jogador 1: ");
            jogador = Console.ReadLine();
        } while (jogador == "");
        Velha.jogador1 = jogador;

        Console.Clear();

        do
        {
            Console.Write("jogador 2: ");
            jogador = Console.ReadLine();
        } while (jogador == "");
        Velha.jogador2 = jogador;

        Velha.Tabuleiro();

        do
        {

            Console.WriteLine("\nvez de {0} (X)", Velha.jogador1);

            Velha.JogaJogo(); Velha.LinhasJ1(); Velha.Tabuleiro(); 
            
            Velha.rod++;

            if (Velha.Qganhou() == -1)
            {
                Console.WriteLine("\nvez de {0} (O)", Velha.jogador2);

                Velha.JogaJogo(); Velha.LinhasJ2(); Velha.Tabuleiro();
            }
        } while (Velha.Qganhou() == -1);

        Velha.MostraVencedor();
        Console.ReadKey();
    }
}