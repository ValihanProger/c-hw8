/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] table = new int[4, 4];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SmallestSumSequence(int[,] array)
{
    int[] sequenceSum = new int [4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = temp + array[i,j];
        }
        sequenceSum[i] = temp;
        temp = 0;
    }
    for (int i = 0; i < sequenceSum.Length; i++)
    {
        // Console.WriteLine($"{sequenceSum[i]} ");
        for (int j = i + 1; j < sequenceSum.Length; j++)
        {
            if (sequenceSum[i]>sequenceSum[j])
            {
                int temp1 = sequenceSum[i];
                sequenceSum[i] = sequenceSum[j];
                sequenceSum[j] = temp1;
            }
        }
    }
    Console.Write($"Наименьшая сумма элементов в массиве -> {sequenceSum.First()}");
    // for (int i = 0; i < sequenceSum.Length; i++)
    // {
    //     Console.Write($"{sequenceSum[-1]} ");
    // }
}


FillArrayRandom(table);
PrintArray(table);
SmallestSumSequence(table);