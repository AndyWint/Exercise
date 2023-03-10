// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

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

void PrintSimpleArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
}

int[] SumRow(int[,] array)
{
    int[] helpArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumLine = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumLine = sumLine + array[i, j];
        }
        helpArray[i] = sumLine;
    }
    return helpArray;
}

int Compare(int[] array)
{
    int min = array[0];
    int line = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            line = i + 1;
            min = array[i];
        }
    }
    if (line == 0)
    {
        line = 1;
    }
    return line;
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
PrintSimpleArray(SumRow(matrix));
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов - {Compare(SumRow(matrix))}");

