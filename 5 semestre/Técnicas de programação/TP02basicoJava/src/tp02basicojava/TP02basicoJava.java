package tp02basicojava;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class TP02basicoJava {

    public static void main(String[] args) 
    {
        Scanner readline = new Scanner(System.in);
        Scanner readline2 = new Scanner(System.in);
        
        int escolha = 0;        
        String fim;
        do{

            do{     
                System.out.println("Qual exercício você deseja checar?");
                escolha = readline.nextInt();            
            } while (escolha<1 || escolha>6);
        
            System.out.println("-");

            switch (escolha) {
                case 1 -> exercicio1();
                case 2 -> exercicio2();
                case 3 -> exercicio3();
                case 4 -> exercicio4();
                case 5 -> exercicio5();
                case 6 -> exercicio6();
            }

            System.out.println("Deseja encerrar o programa?");
            fim = readline2.nextLine();
        }while (!fim.equals("sim"));

        readline.close();
        readline2.close();
    }
    
    /*
     Exercícios
    */

    public static void exercicio1()
    {
        for (int i = 1; i < 16; i++)
        {
            int num = (int)Math.pow(i, 2)+1;
            System.out.println(num);
        }
    }

    public static void exercicio2()
    {
        float num, soma = 0;
        Scanner scan = new Scanner(System.in);
        List<Integer> div = new ArrayList<>();

        System.out.print("Entre com o número a ser verificado: ");
        num = scan.nextInt();
        
        for (int i = 1; i < num; i++) if (num%i == 0) div.add(i);

        for (int i = 0; i < div.size(); i++) soma += (int)div.get(i);

        if (soma == num) System.out.println("O número é perfeito.");
        else System.out.println("O número não é perfeito");
    }

    public static void exercicio3()
    {
        Scanner scan = new Scanner(System.in);

        System.out.println("Qual tamanho da sequência de fibonacci desejado?");
        int tam = scan.nextInt();

        System.out.println("\n-\n");

        Fibonacci.verFibonacci(tam);
    }

    public static void exercicio4()
    {
        float soma = 0;
        int countPar = 0, countImpar = 0;
        Random r = new Random();
        int[] n = new int[20];
        
        for (int i = 0; i < n.length; i++) n[i] = r.nextInt();

        
        for (int i = 0; i < n.length; i++) soma += n[i];
        
        soma /= n.length;
        
        for (int i = 0; i < n.length; i++)
        {
            if (n[i]%2 == 0) countPar++;
            else countImpar++;
        }

        System.out.println("A média final aleatória foi " + soma);
        System.out.println("A quantidade de números pares foi de "+ countPar);
        System.out.println("A quantidade de números ímpares foi de "+ countImpar);
    }

    public static void exercicio5()
    {
        float soma = 0;
        int countPar = 0, countImpar = 0;
        List<Integer> n = new ArrayList<>();
        Random r = new Random();
        
        for (int i = 0; i < 20; i++) n.add(r.nextInt());

        
        for (int i = 0; i < n.size(); i++) soma += n.get(i);

        soma /= n.size();
        
        for (int i = 0; i < n.size(); i++)
        {
            if (n.get(i)%2 == 0) countPar++;
            else countImpar++;
        }

        Collections.sort(n);

        for (int i = 0; i < n.size(); i++)  System.out.println(i+1 + "°: " + n.get(i));
        
        System.out.println("A média final aleatória foi " + soma);
        System.out.println("A quantidade de números pares foi de "+ countPar);
        System.out.println("A quantidade de números ímpares foi de "+ countImpar);
    }

    public static void exercicio6()
    {        
        Scanner scan = new Scanner(System.in);
        int escolha = 0;

        do
        {
            System.out.println("1 - Agendar\n2 - Listar agenda\n3 - Fim");
            escolha = scan.nextInt();

            if (escolha != 1 && escolha != 2 && escolha != 3)
                System.out.println("Valor inválido");

        } while(escolha != 1 && escolha != 2 && escolha != 3);


        if (escolha == 1)
        {
            Scanner auxScann = new Scanner(System.in);
            System.out.println("Qual dia da semana você gostaria de agendar?\n2 - Segunda\n3 - Terça\n4 - Quarta\n5 - Quinta\n6 - Sexta");
            int dia = scan.nextInt();

            System.out.println("Qual horário você gostaria de agendar das 8 às 11?");
            int horario = scan.nextInt();

            System.out.println("Qual nome você gostaria de registrar?");
            String nome = auxScann.nextLine();

            AgendaSemanal.agendar(dia, horario, nome);
        }
        if (escolha == 2)
        {
            AgendaSemanal.Listar();
        }
    }
    
    /*
     * Classes
    */

    public static class Fibonacci
    {
        private static int a = 1, b = 1, c;
        
        public static void verFibonacci(int tam)
        {
            if (tam == 0) return;
            
            c = a + b;
            a = b;
            b = c;
            
            System.out.println(c);
            verFibonacci(tam-1);
        }
    }   
    
    public static class AgendaSemanal
    {
        private static String[][] agenda = new String[5][4];

        public static void agendar(int _dia, int _horario, String nome)
        {
            int dia = _dia-2, horario = _horario-8;

            if (agenda[dia][horario] == null) 
            {
                agenda[dia][horario] = nome;
                System.out.println("Horário agendado com sucesso");
            }
            else 
                System.out.println("O horário já está ocupado");
        }

        public static void Listar()
        {
            // Arrays com os dias da semana e horários
            String[] dias = {"Segunda", "Terça", "Quarta", "Quinta", "Sexta"};
            String[] horarios = {"08h", "09h", "10h", "11h"};

            // Percorrendo a matriz e exibindo os dados
            for (int i = 0; i < agenda.length; i++) {
                System.out.println(dias[i] + ":"); // Exibe o dia da semana
                for (int j = 0; j < agenda[i].length; j++) {
                    System.out.println("  " + horarios[j] + " - " + agenda[i][j]);
                }
                System.out.println(); // Quebra de linha entre os dias
            }
        }
    }
}
