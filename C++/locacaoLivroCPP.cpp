#include <iostream>
#include <stdio.h>
#include <iomanip>

using namespace std;

int calcularMulta(int i){
    double multa = 0;
    if(i > 0){
        multa = i * 1.5;
    }
    return multa;
}

int main()
{
    double valorLocacao, diasAtraso, multa;
    
    cout << "Valor da locação do Livro: ";
    cin >> valorLocacao;
    
    cout << "Dias de atraso da entrega: ";
    cin >> diasAtraso;
    
    multa = calcularMulta(diasAtraso);
    
    
    cout << fixed << setprecision(2);
    cout << "Valor do livro locado: " << valorLocacao << " R$" << endl;
    cout << "Valor da Multa: " << multa << " R$" << endl;
    
    return 0;
}