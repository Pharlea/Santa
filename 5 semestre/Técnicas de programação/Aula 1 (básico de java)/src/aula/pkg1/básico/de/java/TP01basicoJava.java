package aula.pkg1.básico.de.java;
import java.util.Scanner;

public class TP01basicoJava {

    public static void main(String[] args) {
        Scanner readline = new Scanner(System.in);
        
        int escolha = 0;
        
        
        do{     
            System.out.println("Qual exercício você deseja checar?");
            escolha = readline.nextInt();            
        } while (escolha!=1 && escolha!=2 && escolha!=3 && escolha!=4);
        
        if (escolha == 1){
         Scanner celScan = new Scanner(System.in);
         float celInt, farInt;
         
         System.out.println("Digite a temperatura em celcius:");
         celInt = celScan.nextInt();
         
         farInt = (float)(celInt*1.8)+32;

         System.out.println(farInt + "°F");
        }

        if (escolha == 2){
            float[] notas = new float[4];
            Scanner scanNotas = new Scanner(System.in);
            
            for (int i = 0; i < 4; i++){
            int show = i + 1;
            System.out.println("Digite a "+ show +"° nota");
            notas[i] = scanNotas.nextInt();
            }
            
            float media = 0;
            for (int i = 0; i < 4; i++){
                media += notas[i];
            }
            media /= 4;
            
            System.out.print("A média final foi de " + media);
            
            if (media > 6){
                System.out.print(" portanto o aluno está aprovado.");
            }
            else{
                if (media < 3){
                    System.out.print(" portanto o aluno está reprovado.");    
                }
                else{
                    System.out.print(" portanto o aluno está de exame.");
                }
            }
        }
        
        if (escolha == 3){
            float[] valores = new float[4];
            Scanner scanValores = new Scanner(System.in);
            
            for (int i = 0; i < 4; i++){
            int show = i + 1;
            System.out.println("Digite o "+ show +"° valor");
            valores[i] = scanValores.nextInt();
            }
            
            float media = 1;
            for (int i = 0; i < 4; i++){
                media *= valores[i];
            }
            media = (float)Math.pow(media, 0.25);
            
            System.out.println("A média geométrica dos números inseridos é de " + media);
        }
        
        if (escolha == 4){
            int mes, ano;
            Scanner scan = new Scanner(System.in);
            
            System.out.println("Digite o ano: ");
            ano = scan.nextInt();
            
            do{
                System.out.println("Digite o mês: ");
                mes = scan.nextInt();
                
                if ((mes > 12 || mes < 1)){
                    System.out.println("Mês inválido");
                }
            } while (mes > 12 || mes < 1);
            
            if (mes == 1||mes == 3||mes == 5||mes == 7||mes == 8||mes == 10||mes == 12){
                System.out.println("O mês têm 31 dias");
                return;
            }
            if (mes == 4||mes == 6||mes == 9||mes == 11){
                System.out.println("O mês têm 30 dias");
                return;
            }
            
            float bi = (float)ano/4;
            if (bi == (int)bi){
                System.out.println("O mês têm 29 dias");
            }
            else{
                System.out.println("O mês têm 28 dias");
            }
        }
    }   
}
