// O método é uma operação que é realizada sobre o objeto e o campo é onde se armazena os dados de uma classe
// PROPRIEDADE - a fusão do método com o campo 
// get - leitura
// set - gravação

//class program
//{
//    class Animal
//    {
//        private string nome;

//        public string AtribuirNome
//        {
//            set
//            {
//                this.nome = value;
//            }
//        }

//        public string RetornaNome
//        {
//            get
//            {
//                return (this.nome);
//            }
//        }

//        public void Acordar (string info)
//        {
//            Console.WriteLine ("{0} acordou...", info);
//        }

//        public void Comer (string info)
//        {
//            Console.WriteLine("{0} comeu...", info);
//        }

//        public void Dormir(string info)
//        {
//            Console.WriteLine("{0} dormiu...", info);
//        }
//    }

//    static void Main (string[] args)
//    {
//        Animal especie = new Animal();
//        especie.AtribuirNome = "Leão";
//        especie.Acordar (especie.RetornaNome);
//        especie.Comer(especie.RetornaNome);
//        especie.Dormir(especie.RetornaNome);
//    }
//}


//class Program
//{
//    class Triangulo
//    {
//        private int lado1 = 10;
//        private int lado2 = 10;
//        private int lado3 = 10;

//        public int TamanhoLado1
//        {
//            set { this.lado1 = value; }
//        }

//        public int TamanhoLado2
//        {
//            set { this.lado2 = value; }
//        }

//        public int TamanhoLado3
//        {
//            set { this.lado3 = value; }
//        }

//        public void MostraLados()
//        {
//            Console.WriteLine("Lado 1 = {0}", lado1);
//            Console.WriteLine("Lado 2 = {0}", lado2);
//            Console.WriteLine("Lado 3 = {0}", lado3);
//            Console.WriteLine();
//            Console.ReadKey();
//        }
//    }

//    static void Main(string[] args)
//    {
//        Triangulo a = new Triangulo { TamanhoLado3 = 15 };
//        a.MostraLados();

//        Triangulo b = new Triangulo { TamanhoLado1 = 15, TamanhoLado3 = 20 };
//        b.MostraLados();

//        Triangulo c = new Triangulo { TamanhoLado2 = 12, TamanhoLado3 = 17 };
//        c.MostraLados();

//        Triangulo d = new Triangulo { TamanhoLado1 = 09, TamanhoLado2 = 12, TamanhoLado3 = 15 };
//        d.MostraLados();
//    }
//}

class Program
{
    class Triangulo
    {
        private int lado1 = 10;
        private int lado2 = 10;
        private int lado3 = 10;

        public Triangulo(string info)
        {
            Console.WriteLine(info);
        }

        public int TamanhoLado1
        {
            set { this.lado1 = value; }
        }

        public int TamanhoLado2
        {
            set { this.lado2 = value; }
        }

        public int TamanhoLado3
        {
            set { this.lado3 = value; }
        }

        public void MostraLados()
        {
            Console.WriteLine("Lado 1 = {0}", lado1);
            Console.WriteLine("Lado 2 = {0}", lado2);
            Console.WriteLine("Lado 3 = {0}", lado3);
            Console.WriteLine();
            Console.ReadKey();
        }

        public void AlteraDados(int lado1)
        {
            this.lado1 = lado1;
        }

        public int Retorna
        {
            get { return this.lado1; }
        }
    }

    static void Main(string[] args)
    {
        Triangulo a = new Triangulo("Equilátero")
        {
            TamanhoLado1 = 12,
            TamanhoLado2 = 12,
            TamanhoLado3 = 12
        };

        a.MostraLados();
        a.AlteraDados(25);
        a.MostraLados();
        Console.WriteLine(a.Retorna);
        Console.ReadKey();
    }
}



