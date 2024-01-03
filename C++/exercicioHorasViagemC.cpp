#include <stdio.h>
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    double qtdeDiasViagem;
    double qtdeHorasViagem;
    double totalHorasViagem;
    const double HORASDIA = 24;
    
    cout << "Quantos dias durou sua viagem? " << endl;
    cin >> qtdeDiasViagem;
    
    cout << "Quantas horas durou sua viagem além dos dias? " << endl;
    cin >> qtdeHorasViagem;
    
    totalHorasViagem = (qtdeDiasViagem*HORASDIA) + qtdeHorasViagem;
    
    cout << fixed << setprecision(2);
    cout << "Sua viagem durou um total de " << totalHorasViagem << " horas!" << endl;

    return 0;
}