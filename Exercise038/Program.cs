// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

int[,] SortRows(int[,] matrix, int row)
{
    int[] TempArr = new int[matrix.GetLength(1)];
    for (int i = 0; i < TempArr.Length; i++) TempArr[i] = matrix[row, i];
    TempArr = Sort(TempArr);
    for (int i = 0; i < TempArr.Length; i++) matrix[row, i] = TempArr[i];
    return matrix;
}

int[] Sort(int[] array)
{
    int help = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                help = array[j + 1];
                array[j + 1] = array[j];
                array[j] = help;
            }
        }
    }
    return array;
}


int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

SortRows(matrix, 0);
SortRows(matrix, 1);
SortRows(matrix, 2);
PrintArray(matrix);



