/*
 3-) Faça um programa que leia cinco números, guarde-os num vetor, e ordene-os de forma crescente em um novo vetor.
 */
const int MAX = 5;
float[] numeros = new float[MAX];
int i, j=(MAX-1), maior = 0;
float aux = 0;
float[] numeros_ordenados = new float[MAX];

for (i = 0; i < MAX; i++)
{
    Console.Write($"\nDigite o {(i+1)}º número: ");
    numeros[i] = float.Parse( Console.ReadLine() );
    numeros_ordenados[i] = numeros[i];
}
do
{
    for (i = 0; i < j; i++)
    {
        if (numeros_ordenados[i] > numeros_ordenados[i + 1])
        {
            aux = numeros_ordenados[i + 1];
            numeros_ordenados[i + 1] = numeros_ordenados[i];
            numeros_ordenados[i] = aux;
        }
    }
    j--;
}while(j>=0);
Console.Write("\nOs números em ordem crescente são: ");
for (i = 0; i < MAX; i++)
{
    Console.Write($"{numeros_ordenados[i]} ");
}
Console.WriteLine();