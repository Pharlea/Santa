/*class Program
{ 
    public class Animal 
    { public string Nome;
        public int Idade; 
        public string CorDoPelo; 
    } 
    public class Cachorro : Animal 
    { 
        public string Raca; 
        public Cachorro()    // construtor padrão
        {            
            Nome = "Poli";            
            Idade = 12;            
            CorDoPelo = "branca";            
            Raca = "Dálmata";        
        }        
        public void ExibeDados()        
        {            
            Console.WriteLine(Nome);            
            Console.WriteLine(Idade);            
            Console.WriteLine(CorDoPelo);            
            Console.WriteLine(Raca);            
            Console.ReadKey();        
        }    
    }    
    static void Main(string[] args)    
    {        
        Cachorro cao = new Cachorro();        
        cao.ExibeDados();    
    } 
} */

public class Figura 
{ 
    public float Area { get; set; } 
}
public class Quadrado : Figura 
{ public int Lado { get; set; } 
    public int CalculaAreaQuadrado() 
    { 
        return (int)Math.Pow(Lado, 2); 
    } 
}
public class Retangulo : Figura 
{ 
    public int Base { get; set; } 
    public int Altura { get; set; } 
    public int CalculaAreaRetangulo() 
    { 
        return (Base * Altura); 
    } 
}
public class Triangulo : Retangulo 
{ 
    public int CalculaAreaTriangulo() 
    { 
        return ((Base * Altura) / 2); 
    } 
}
public class Circulo : Figura 
{ public int Raio { get; set; } 
    public float CalculaAreaCirculo() 
    { 
        return (int)Math.PI * (int)Math.Pow(Raio, 2); 
    } 
}
class Program 
{ 
    static void Main(string[] args) 
    { 
        int opcao; Quadrado quadrado = new Quadrado(); 
        Retangulo retangulo = new Retangulo(); 
        Triangulo triangulo = new Triangulo(); 
        Circulo circulo = new Circulo(); 
        do 
        { 
            Console.Clear(); 
            Console.WriteLine("1 - Quadrado "); 
            Console.WriteLine("2 - Retângulo"); 
            Console.WriteLine("3 - Triângulo"); 
            Console.WriteLine("4 - Círculo  "); 
            Console.WriteLine("5 - Fim      "); 
            opcao = int.Parse(Console.ReadLine()); 
            switch (opcao) 
            { 
                case 1: Console.Write("Digite o lado do quadrado: "); quadrado.Lado = int.Parse(Console.ReadLine()); quadrado.Area = quadrado.CalculaAreaQuadrado(); Console.WriteLine("Área do quadrado é {0}", quadrado.Area); Console.ReadKey(); break; 
                case 2: Console.Write("Digite a base do retângulo: "); retangulo.Base = int.Parse(Console.ReadLine()); Console.Write("Digite a altura do retângulo: "); retangulo.Altura = int.Parse(Console.ReadLine()); retangulo.Area = retangulo.CalculaAreaRetangulo(); Console.WriteLine("Área do retângulo é {0}", retangulo.Area); Console.ReadKey(); break; 
                case 3: Console.Write("Digite a base do triângulo: "); triangulo.Base = int.Parse(Console.ReadLine()); Console.Write("Digite a altura do retângulo: "); triangulo.Altura = int.Parse(Console.ReadLine()); triangulo.Area = triangulo.CalculaAreaTriangulo(); Console.WriteLine("Área do triângulo é {0}", triangulo.Area); Console.ReadKey(); break; 
                case 4: Console.Write("Digite o raio do círculo: "); circulo.Raio = int.Parse(Console.ReadLine()); circulo.Area = circulo.CalculaAreaCirculo(); Console.WriteLine("Área do círculo é {0}", circulo.Area); Console.ReadKey(); break; 
            } 
        } while (opcao != 5); 
    } 
} 
