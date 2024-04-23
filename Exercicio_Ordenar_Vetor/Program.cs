/*
 3-) Faça um programa que leia cinco números, guarde-os num vetor, e ordene-os de forma crescente em um novo vetor.
 */
const int MAX = 5;
float[] numeros = new float[MAX];
int i, j=(MAX-1), maior = 0;
float aux = 0;
for (i = 0; i < MAX; i++)
{
    Console.Write($"\nDigite o {(i+1)}º número: ");
    numeros[i] = float.Parse( Console.ReadLine() );
}
do
{
    for (i = 0; i < j; i++)
    {
        if (numeros[i] > numeros[i + 1])
        {
            aux = numeros[i + 1];
            numeros[i + 1] = numeros[i];
            numeros[i] = aux;
        }
    }
    j--;
}while(j>=0);
Console.Write("\nOs números em ordem crescente são: ");
for (i = 0; i < MAX; i++)
{
    Console.Write($"{numeros[i]} ");
}
Console.WriteLine();