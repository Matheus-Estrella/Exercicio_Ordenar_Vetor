/*
 3-) Faça um programa que leia cinco números, guarde-os num vetor, e ordene-os de forma crescente em um novo vetor.
 */
const int MAX = 10;
float[] numeros = new float[MAX];
int i, j=(MAX-1), maior = 0, op = 0;
float aux = 0;
float[] numeros_ordenados = new float[MAX];
float[] numeros_sem_repetir = new float[MAX];

do
{
    Console.WriteLine("\nDeseja inserir valores:\n\n1-) Manualmente\n2-) Aleatóriamente\n");
    op = int.Parse(Console.ReadLine());
} while ((op < 1) || (op > 2));

for (i = 0; i < MAX; i++)
{
    if(op == 1)
    {
        Console.Write($"\nDigite o {(i + 1)}º número: ");
        numeros[i] = float.Parse(Console.ReadLine());
    }
    else
    {
        numeros[i] = new Random().Next(0, 100);
    }
    numeros_ordenados[i] = numeros[i];
}

// Ordenando ...

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


////REMOVENDO REPETIÇÕES...

j = 0;

for(i=1;i<MAX; i++)
{
    if ((numeros_ordenados[i] != numeros_ordenados[i-1]))
    {
        numeros_sem_repetir[j] = numeros_ordenados[i - 1];
        j++;
    }
    if(i == MAX - 1)
    {
        numeros_sem_repetir[j] = numeros_ordenados[i];
    }
}
Console.Write("\nOs números em ordem crescente não repetidos são: ");

for (i = 0; i <= j; i++)
{
    Console.Write($"{numeros_sem_repetir[i]} ");
}
Console.WriteLine();

Console.Write("\nOs números em ordem decrescente não repetidos são: ");

for (i = 0; i <= j; i++)
{
    Console.Write($"{numeros_sem_repetir[j-i]} ");
}
Console.WriteLine();