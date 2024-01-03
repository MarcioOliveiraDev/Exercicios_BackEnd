PRECOGASOLINA = 7.199 
PRECOETANOL = 5.419
PRECOGNV = 4.245

qtdeGasolina = float(input("Quantidade de gasolina em litros: "))
qtdeEtanol = float(input("Quantidade de etanol em litros: "))
qtdeGNV = float(input("Quantidade de GNV em M³: "))

totalGasolina = PRECOGASOLINA * qtdeGasolina
totalEtanol = PRECOETANOL * qtdeEtanol
totalGNV = PRECOGNV * qtdeGNV

valorTotal = totalEtanol + totalGasolina + totalGNV

print(f"Valor abastecido em gasolina: {totalGasolina:.2f} R$")
print(f"Valor abastecido em etanol: {totalEtanol:.2f} R$")
print(f"Valor abastecido em GNV: {totalGNV:.2f} R$")
print(f"Valor total a ser pago {valorTotal:.2f} R$")
