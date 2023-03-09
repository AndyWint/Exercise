// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} * ");
        }
        Console.WriteLine();
    }
}

int CheckElement(int[,] arr)
{
    Console.Write("Введите значение строки - ");
    int coordinateOne = int.Parse(Console.ReadLine());
    Console.Write("Введите значение столбца - ");
    int coordinateTwo = int.Parse(Console.ReadLine());
    int number = arr[coordinateOne - 1, coordinateTwo - 1];
    return number;
}

void FindElement(int[,] arr)
{
    Console.Write("Введите число для поиска в диапазоне от -10 до 10 - ");
    int number = int.Parse(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //int count = 0;
            if (arr[i, j] == number)
            {
                Console.Write($" элемент {arr[i, j]}, координаты элемента ({i}, {j}) ");
                Console.WriteLine();
                count++;
            }
        }
        Console.WriteLine();
    }
    if (count == 0)
    {
        Console.Write("Такого элемента не найдено");
    }
}


int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(CheckElement(matrix));
Console.WriteLine("`````");
FindElement(matrix);




