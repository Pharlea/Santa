namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio;
            TimeSpan tempoTotal;

        inicio = DateTime.Now;

            Parallel.Invoke(
                () =>
                {
                    fakeProcesso(1, 5000);
                    fakeProcesso(4, 3000);
                },
                () =>
                {
                    fakeProcesso(2, 4000);
                    fakeProcesso(5, 5000);
                },
                () =>
                {
                    fakeProcesso(3, 3000);
                }
                );
            fakeProcesso(6, 1000);
            
            tempoTotal = DateTime.Now - inicio;
            Console.WriteLine("O tempo total de execução dos processos foi de {0}s", tempoTotal.TotalSeconds);

            Console.ReadKey();
        }

        public static void fakeProcesso (int id, int tempo)
        {
            DateTime inicio;
            TimeSpan espera;

            inicio = DateTime.Now;

            Console.WriteLine("Iniciando o processo {0}", id);
            Thread.Sleep(tempo);

            espera = DateTime.Now - inicio;

            Console.WriteLine("O processo {0} foi concluído em {1}s", id, espera.TotalSeconds);

            
        }
    }
}