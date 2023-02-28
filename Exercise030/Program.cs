// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



void FillArray(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

void Dev(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        int numb = arr[i];
        int result = arr[i] % 2;
        if (result == 0)
        {
            Console.WriteLine(numb);
        }
    }
}



int Count(int[] arr)
{
    int count = 0;
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        int result = arr[i] % 2;
        if (result == 0)
        {
            count++;
        }
    }
    return count;
}


int[] arr = new int[4];
FillArray(arr);
PrintArray(arr);
Console.WriteLine(" ");
int A = Count(arr);
Console.WriteLine($"Количество четных чисел равно - {A}");
Dev(arr);






