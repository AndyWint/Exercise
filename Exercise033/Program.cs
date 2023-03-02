//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArr(int number)
{
    return new int[number];
}

void FillArr(int[] arr)
{
    Console.WriteLine("Введите число - ");
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
}

int NumberMoreNull(int[] arr)
{
    int count = 0;
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArr(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

Console.WriteLine($"Введите желаемое количество чисел: ");
int A = int.Parse(Console.ReadLine());
int[] arr = CreateArr(A);
Console.WriteLine("````");

FillArr(arr);
NumberMoreNull(arr);

Console.WriteLine("````");
int Max = NumberMoreNull(arr);
Console.WriteLine($"Количество чисел больше 0: {Max}");



