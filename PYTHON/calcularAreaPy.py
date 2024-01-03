PI = 3.14159

lado_Quadrado = float(input("Valor do lado do quadrado em Metros: "))

area_Quadrado = lado_Quadrado * lado_Quadrado
area_Circulo = PI * (lado_Quadrado*lado_Quadrado)
area_Total = area_Quadrado + (area_Circulo/2)

print(f"O valor total daárea do objeto: {area_Total:.3f} M²!")