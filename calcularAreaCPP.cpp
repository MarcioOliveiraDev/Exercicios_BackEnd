#include <iostream>
#include <stdio.h>
#include <iomanip>

using namespace std;

int main()
{
    const double PI = 3.14159;
    double lado_Quadrado, area_Quadrado, area_Circulo, area_Total;
    
    cout<<"Quanto mede o lado do Quadrado em METROS? ";
    cin >> lado_Quadrado;
    
    area_Quadrado = lado_Quadrado*lado_Quadrado;
    area_Circulo = PI * (lado_Quadrado*lado_Quadrado);
    area_Total = area_Quadrado + (area_Circulo/2);
    
    cout << fixed << setprecision(2);
    cout << "Valor total da área: " << area_Total <<" m²!" << endl;

    return 0;
}