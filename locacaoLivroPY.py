
def calcularMulta(i):
    if i > 0:
        return i * 1.5
    else:
        return 0
    
def main():
    valorLocacao = float(input("Valor da locação do Livro: "))
    diasAtraso = float(input("Dias de atraso da entrega: "))
    multa = calcularMulta(diasAtraso)
    
    print(f"Valor do livro locado: {valorLocacao:.2f} R$")
    print(f"Valor da Multa: {multa:.2f} R$")
    
if __name__ == "__main__":
    main()