/**
 * calcularAreaJ
 */
import java.util.Scanner;
public class calcularAreaJ {
    public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        final double PI = 3.14159;
        double ladoQuadrado, areaCirculo, areaQuadrado, areaTotal;

        System.out.println("Quanto mede o lado do quadrado em metros: ");
        ladoQuadrado = teclado.nextDouble();
        areaQuadrado = ladoQuadrado * ladoQuadrado;
        areaCirculo = PI * (ladoQuadrado*ladoQuadrado);
        areaTotal = areaQuadrado + (areaCirculo/2); 
        
        System.out.printf("Área total em M²: %.2f m²", areaTotal);
    
        teclado.close();
    }
    
}


