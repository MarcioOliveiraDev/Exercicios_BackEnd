/**
 * diaUtil
 */
import java.util.Scanner;
public class diaUtil {
    public static void main(String[] args) {
        try (Scanner teclado = new Scanner(System.in)) {
            System.out.println("1 - Domingo");
            System.out.println("2 - Segunda-feira");
            System.out.println("3 - Terça-feira");
            System.out.println("4 - Quarta-feira");
            System.out.println("5 - Quinta-feira");
            System.out.println("6 - Sexta-feira");
            System.out.println("7 - Sábado");
            
            System.out.print("Informe número correspondente as dia da semana: ");
            int diaSemana = teclado.nextInt();

            if (diaSemana == 1 || diaSemana == 7) {
                System.out.println("DIA NÃO ÚTIL DA SEMANA!");
            } 
            else{
                System.out.println("DIA ÚTIL DA SEMANA!");
            }
        }
    }
}