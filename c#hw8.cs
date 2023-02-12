// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int number;
while (true)  // Ввод размера квадрата
{
    Console.Write("Введите целое число (input > 3): ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number > 3)
    {
        break;
    }
    Console.Write("Неверное число\n");
}
int[,] array = new int[number, number];
array[0, 3] = 4;
int count = 1;
int col = 1;
while (true) 
{
    if (array[col-1, col-1] != 0) // Проверка на конец спирали 
    {
        break;
    }
    for (int j = col - 1; j < array.GetLength(0) - col + 1; j++) // Заполнение первой горизонтали(слева на право)
    {
        array[col-1, j] = count;
        count++;
    }
    for (int i = col; i < array.GetLength(1) - col + 1; i++) // Заполнение первой вертикали(сверху вниз)
    {
        array[i, array.GetLength(1) - col] = count;
        count++;
    }

    for (int j = array.GetLength(1) - col - 1; j >= col - 1; j--) // Заполнение второй горизонтали (спава на лево)
    {
        array[array.GetLength(1) - col, j] = count;
        count++;
    }
    for (int i = array.GetLength(1) - col - 1; i >= col; i--) // Заполнение второй вертикали (снизу вверх)
    {
        array[i, col - 1] = count;
        count++;
    }
    col++;
}

for (int i = 0; i < array.GetLength(0); i++) // Ввыод квадрата 
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write(j == array.GetLength(1) - 1 ? array[i, j] + "\n" : array[i, j] + "\t");
    }
}
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int number;
while (true)  // Ввод размера квадрата
{
    Console.Write("Введите целое число (input > 3): ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number > 3)
    {
        break;
    }
    Console.Write("Неверное число\n");
}
int[,] array = new int[number, number];
array[0, 3] = 4;
int count = 1;
int col = 1;
while (true) 
{
    if (array[col-1, col-1] != 0) // Проверка на конец спирали 
    {
        break;
    }
    for (int j = col - 1; j < array.GetLength(0) - col + 1; j++) // Заполнение первой горизонтали(слева на право)
    {
        array[col-1, j] = count;
        count++;
    }
    for (int i = col; i < array.GetLength(1) - col + 1; i++) // Заполнение первой вертикали(сверху вниз)
    {
        array[i, array.GetLength(1) - col] = count;
        count++;
    }

    for (int j = array.GetLength(1) - col - 1; j >= col - 1; j--) // Заполнение второй горизонтали (спава на лево)
    {
        array[array.GetLength(1) - col, j] = count;
        count++;
    }
    for (int i = array.GetLength(1) - col - 1; i >= col; i--) // Заполнение второй вертикали (снизу вверх)
    {
        array[i, col - 1] = count;
        count++;
    }
    col++;
}

for (int i = 0; i < array.GetLength(0); i++) // Ввыод квадрата 
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write(j == array.GetLength(1) - 1 ? array[i, j] + "\n" : array[i, j] + "\t");
    }
}

