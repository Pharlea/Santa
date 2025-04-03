class program
{
    class livro
    {

        private bool Disponibilidade = true;

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public bool Disponivel
        {
            get { return this.Disponibilidade; } 
        }

        public void Emprestar()
        {
            Disponibilidade = false;
        }

        public void MostraDados ()
        {
            Console.WriteLine("\n\nlivro: {0}", Titulo); 
            Console.WriteLine("autor: {0}", Autor);
            Console.WriteLine("ano de publicação: {0}", AnoPublicacao);
            if (Disponibilidade)
            {
                Console.WriteLine("o livro está disponível");
            }
            else
            {
                Console.WriteLine("o livro está indisponível");
            }
        }
    }

    static void Main (string[] args)
    {
        livro livro1 = new livro();
        Console.Write("entre com o título do livro: ");
        livro1.Titulo = Console.ReadLine();
        Console.Write("entre com o nome do autor: ");
        livro1.Autor = Console.ReadLine();
        do
        {

            Console.Write("entre com o ano em que o livro foi publicado: ");
            livro1.AnoPublicacao = int.Parse(Console.ReadLine());
        } while (livro1.AnoPublicacao < 0);
        Console.Write("digite 1 se você quiser emprestar o livro ou outro número qualquer se não quiser: ");
        int emprestar = int.Parse(Console.ReadLine());
        if (emprestar == 1)
            {
            livro1.Emprestar();
        }
        
                livro livro2 = new livro();
        Console.Write("\nentre com o título do livro: ");
        livro2.Titulo = Console.ReadLine();
        Console.Write("entre com o nome do autor: ");
        livro2.Autor = Console.ReadLine();
        do
        {

            Console.Write("entre com o ano em que o livro foi publicado: ");
            livro2.AnoPublicacao = int.Parse(Console.ReadLine());
        } while (livro2.AnoPublicacao < 0);
        Console.Write("digite 1 se você quiser emprestar o livro ou outro número qualquer se não quiser: ");
        emprestar = int.Parse(Console.ReadLine());
        if (emprestar == 1)
            {
            livro1.Emprestar();
        }
        livro1.MostraDados();
        livro2.MostraDados();
    }
}