////exercício 1
//class produto
//{
//    public double precoEnvio, precoProduto = 100;
//    public virtual void CalcularPrecoEnvio()
//    {
//        precoEnvio = precoProduto * 0.05;
//    }

//    public double precoTotal()
//    {
//        CalcularPrecoEnvio();
//        return precoEnvio + precoProduto;
//    }
//}
//class Livro : produto
//{
//    public override void CalcularPrecoEnvio()
//    {
//        precoEnvio = precoProduto * 0.1;
//    }
//}

//class Eletronico : produto
//{
//    public override void CalcularPrecoEnvio()
//    {
//        precoEnvio = precoProduto * 0.2;
//    }
//}

//class roupa : produto
//{
//    public override void CalcularPrecoEnvio()
//    {
//        precoEnvio = precoProduto * 0.075;
//    }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        produto produto = new produto();
//        Eletronico eletronico = new Eletronico();
//        roupa roupa = new roupa();
//        Livro livro = new Livro();

//        Console.WriteLine("o preço do produto é de {0}R$", produto.precoTotal());
//        Console.WriteLine("o preço do livro é de {0}R$", livro.precoTotal());
//        Console.WriteLine("o preço do eletronico é de {0}R$", eletronico.precoTotal());
//        Console.WriteLine("o preço da roupa é de {0}R$", roupa.precoTotal());
//    }
//}

//exercício 2
class CalculadoraDeArea
{
    public float CalculaTriangulo(float Base, float Altura)
    {
        float area = (Base * Altura) / 2;
        return area;
    }
    public double CalculaRetangulo(float lado1, float lado2)
    {
        double area = lado1 * lado2;
        return area;
    }

    public double CalculaCirculo(float raio)
    {
        double area = 3.14159265359 * Math.Pow(raio, 2);
        return area;
    }
}

class program
{
    static void Main(string[] args)
    {
        CalculadoraDeArea calculadoraDeArea = new CalculadoraDeArea();

        Console.WriteLine("A área do triângulo com base 10 e altura 20 é de {0}", calculadoraDeArea.CalculaTriangulo(10, 20));
        Console.WriteLine("A área do retângulo 30x10 é de {0}", calculadoraDeArea.CalculaRetangulo(30, 10));
        Console.WriteLine("A área de um circulo com raio 20 é de {0}", calculadoraDeArea.CalculaCirculo(20));
    }
}