/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int[,] table = new int[2, 2];

// Функция заполнения массива рандомно числами от 1 до 9
void FillFirstMatrixRandom(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            firstMatrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintFirstMatrix(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write($"{firstMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillSecondMatrixRandom(int[,] secondMatrix)
{
    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            secondMatrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintSecondMatrix(int[,] secondMatrix)
{
    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            Console.Write($"{secondMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindResultOfTwoMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    Console.WriteLine($"{firstMatrix[0,0]}, {secondMatrix[1,0]}");
}



Console.WriteLine("Первая матрица: ");
FillFirstMatrixRandom(table);
PrintFirstMatrix(table);
Console.WriteLine("Вторая матрица: ");
FillSecondMatrixRandom(table);
PrintSecondMatrix(table);