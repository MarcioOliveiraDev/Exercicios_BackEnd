import java.util.Scanner;
public class locacaoLivroJV {

    public static void main(String[] args) {
        try (Scanner teclado = new Scanner(System.in)) {
            System.out.print("Valor da locação do livro: ");
            double valorLocacao = teclado.nextDouble();

            System.out.print("Dias de atraso da entrega: ");
            double diasAtraso = teclado.nextDouble();

            double multa = calcularMulta(diasAtraso);

            System.out.println("Valor do Livro locado: "+valorLocacao+" R$");
            System.out.printf("Valor da multa é: %.2f R$", multa);
        }  
    }

    public static double calcularMulta (double dias) {
        double multa = 0;
        if (dias > 0) {
            multa = dias * 1.5;

           
        }
        return multa;

    }
}
