/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] firstMatrix = new int[2,2];
int[,] secondMatrix = new int[2,2];
int[,] resultMatrix = new int[2,2];
int[] lineFirstMatrix = new int[4];
int[] lineSecondMatrix = new int[4];
int p = 0;
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        firstMatrix[i, j] = new Random().Next(0, 10);
        secondMatrix[i,j] = new Random().Next(0,10);
    }
}
Console.WriteLine("Первая матрица: ");
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        lineFirstMatrix[p] = firstMatrix[i,j];
        Console.Write($"{firstMatrix[i,j]} ");
        p++;
    }
    Console.WriteLine();;
}
p=0;
Console.WriteLine("Вторая матрица: ");
for (int i = 0; i < secondMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        lineSecondMatrix[p] = secondMatrix[i,j];
        Console.Write($"{secondMatrix[i,j]} ");
        p++;
    }
    Console.WriteLine();;
}
Console.WriteLine("Результирующая матрица: ");
var matrix3 = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int n = 0; n < firstMatrix.GetLength(1); n++)
            {
                matrix3[i, j] += firstMatrix[i, n] * secondMatrix[n, j];
            }
        }
    }
}
for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        Console.Write($"{matrix3[i,j]} ");
    }
    Console.WriteLine();
}