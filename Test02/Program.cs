
int numero;
int valorA = 0;
int valorB = 1;
int valorC = 0;

Console.Write("Digite um número inteiro: ");
numero = int.Parse(Console.ReadLine()!);

while (valorC < numero)
{
    valorC = valorA + valorB;
    valorA = valorB;
    valorB = valorC;
}

if (valorC == numero)
{
    Console.WriteLine($"O número {numero}, pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
}
