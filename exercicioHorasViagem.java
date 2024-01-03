import java.util.Scanner;

public class exercicioHorasViagem
{
	public static void main(String[] args) {
	    Scanner teclado = new Scanner(System.in);
	    double qtdeDiasViagem;
	    double qtdeHorasViagem;
	    double totalHorasViagem;
	    double horasDia = 24;
		System.out.println("Quantos dias durou a viagem? ");
		qtdeDiasViagem = teclado.nextDouble();
		System.out.println("Quantas horas além dos dias de viagem? ");
		qtdeHorasViagem = teclado.nextDouble();
		totalHorasViagem = (qtdeDiasViagem * horasDia)+qtdeHorasViagem;
		System.out.printf("Sua viagem durou um total de %.2f horas!", totalHorasViagem);
		teclado.close();
	}
}
