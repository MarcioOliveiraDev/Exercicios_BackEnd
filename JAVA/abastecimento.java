import java.util.Scanner;
public class abastecimento {
    public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        final double PRECOGASOLINA = 7.199, PRECOETANOL = 5.419, PRECOGNV = 4.259;
        double gasolina, etanol, gnv, totalGasolina, totalEtanol, totalGNV, valorTotal;

        System.out.println("Total de litros de gasolina: ");
        gasolina = teclado.nextDouble();
        

        System.out.println("Total de litros de etanol: ");
        etanol = teclado.nextDouble();
        

        System.out.println("Total de m³ de GNV: ");
        gnv = teclado.nextDouble();
        
        
        totalGNV = gnv*PRECOGNV;totalGasolina = gasolina *PRECOGASOLINA;totalEtanol = etanol*PRECOETANOL;
        valorTotal = totalGasolina + totalEtanol + totalGNV;

        System.out.println("============= RECIBO DE COMPRA =============");
        System.out.printf("Valor abastecido em Gasolina:.....%.2f R$\n", totalGasolina);
        System.out.printf("Valor abastecido em Etanol:.......%.2f R$\n", totalEtanol);
        System.out.printf("Valor abastecido em GNV:...........%.2f R$\n", totalGasolina);
        System.out.printf("Valor total da compra:..............%.2f R$", valorTotal);

        teclado.close();




    }        
    
}
