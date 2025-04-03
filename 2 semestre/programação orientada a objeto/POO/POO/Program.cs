//POO = paradigma de progamação orientado a objetos; é uma forma de desenvolvimento de sistemas de softwere que trata o conjunto de componentes que interagem entre si para
//resolver um problema. Esses componentes são denominados Objetos. para ser considerado linguagem de programação orientada a onjeto ela tem que dar suporte a 4 conceitos, que são:

//abstração: é uma coisa que faz parte de um conceito maior, por exemplo: um carro é um abstração de veículo

//a classe é uma abstação do objeto e um objeto é uma intância útil da classe

//classe: todo objeto deriva e uma classe, a classe é o modelo enquanto o objeto é a materialização do modelo, como por exemplo a receita de um bolo é o modelo enquato o bolo é
//o objeto. os objetos têm todas as características da classe da qual eles derivam.a criação de um objeto a pertir de uma classe é chamada de instancialção.



//softwerehouhse = empresa que têm sistemas prontos e vende a licenciamento desses programas, esses programas podem ser personalidades

//fábrica de softwere =  empresa que trabalha criando softweres 













//class program
//{

//    class circle
//    {
//        private int raio; //uma variável dentro de uma classe é chamada de campo
//    }

//    static void Main (string[] args)
//    {
//        circle c;               //cria uma váriavel da Classe            //toda variável do tipo classe armazena o endereço de memória de um objeto
//        c = new circle ();            //inicializa a variável            //new = alocação dinamica de memória = pedir espaço de memória
//    }
//}

//class program
//{
//    class circle
//    {
//        private int raio;

//        public circle()     //método (um módulo que fica dentro de uma classe) | construtor padrão (já que o nome da classe é o mesmo do método)(esse método é chamado automaticamente quando o objeto é instanciado)
//        {
//            raio = 2;
//            Console.Write("olha eu aqui");
//        }
//    }

//    static void Main (string[] args)
//    {
//        circle c = new circle();
//    }
//}

//class program
//{
//    class circle
//    {
//        private int raio;

//        public circle()
//        {
//            raio = 2;
//        }

//        public circle(int raioinicial)          //construtor sobrecarregado | o que diferencia os construtores quando tem mais de 1 é a quantidade de argumentos
//        {
//            raio = raioinicial;
//        }

//        public double area(int raio)
//        {
//            return (Math.PI * this.raio * this.raio);           // com o this ele usa o campo ao invés de utilizar o argumento que foi enviado (utilizar quando o nome do campo e da váriavel são os mesmos)
//        }

//    }

//    static void Main(string[] args)
//    {
//        Console.ReadKey();
//        circle c = new circle();
//        double areadocirculo;
//        int raio = 4;

//        areadocirculo = c.area(raio);
//        Console.WriteLine(areadocirculo);
//        circle d = new circle(4);

//    }
//}

//class program
//{
//    class point
//    {
//        private int x, y;

//        public Point()
//        {
//            Console.WriteLine("método construtor chamado...");
//        }

//        public Point(int x, int y)                                        (NÃO DEU CERTO?????)
//        {
//            this.x = x;
//            this.y = y;
//            Console.WriteLine("Os valores das variáveis são  x:{0} e y:{1}", this.x, this.y);
//        }
//    }

//    static void Main(string[] args)
//    {
//        point valor = new point();

//        Console.ReadKey();
//        Console.Clear();
//        valor = new point(2, 3);
//        Console.ReadKey();
//    }
//}

class program
{
    class Aluno
    {
        string nome;

        public Aluno(string n)
        {
            nome = n;
        }

        public void GravaNome (string n)
        {
            nome = n;
        }

        public string GetNome()
        {
            return (nome);
        }
    }

    static void Main (string[] args)
    {
        Aluno alu = new Aluno("carlos");
        Console.WriteLine("Nome do aluno é {0}", alu.GetNome());

        alu.GravaNome("pedro");
        Console.WriteLine("nome do aluno agora é {0}", alu.GetNome());
    }
}