HORASDIA = 24
qtdeDiasViagem = float(input("Quantos dias durou sua viagem? \n"))
qtdeHorasViagem = float(input("Quantas horas durou a viagem além dos dias informados? \n"))
totalHoras = (HORASDIA * qtdeDiasViagem) + qtdeHorasViagem
print(f"Sua viagem durou um total de {totalHoras:.2f} horas!")