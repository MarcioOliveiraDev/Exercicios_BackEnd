#include <stdio.h>
#include <iostream>
#include <iomanip>
using namespace std;


int main()
{
    const double PRECOGASOLINA = 7.199, PRECOETANOL = 5.419, PRECOGAGNV = 4.259;
    double gasolina, etanol, gnv, totalGasolina, totalEtanol, totalGNV, valorTotal;
    
    cout << "Total de litros de gasolina: ";
    cin >> gasolina;
    
    cout << "Total de litros de etanol: ";
    cin >> etanol;
    
    cout << "Total de m³ de GNV: ";
    cin >> gnv;
    
    totalGasolina = gasolina*PRECOGASOLINA; totalEtanol = etanol*PRECOETANOL; totalGNV = gasolina*PRECOGAGNV;
    valorTotal = totalGasolina + totalEtanol + totalGNV;
    
    cout << "============= RECIBO DE COMPRA =============\n";
    cout << "Valor abastecido em Gasolina:....." << totalGasolina <<" R$\n";
    cout << "Valor abastecido em Etanol:......." << totalEtanol  <<" R$\n";
    cout << "Valor abastecido em GNV:..........." << totalGNV  <<" R$ \n";
    cout << "Valor total da compra:.............." << valorTotal << " R$" <<  endl;

    return 0;
}