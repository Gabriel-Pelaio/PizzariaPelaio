vetor = []
for i in range(10):
numero = int(input("Digite um número inteiro: "))
vetor.append(numero)


print("Vetor no sentido normal:")
for numero in vetor:
print(numero, end=" ")


print("\nVetor no sentido reverso:")
for i in range(len(vetor)-1, -1, -1):
    print(vetor[i], end=" ")
