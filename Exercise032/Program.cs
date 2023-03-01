//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//  [3 7 22 2 78] -> 76

int[] CreateArr(int len)
{
    return new int[len];
}

void FillArr(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 99);
    }
}

void PrintArr(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int FindMax(int[] arr)
{
    int len = arr.Length;
    int max = 0;
    for (int i = 0; i < len; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            i++;
        }
    }
    return max;
}

int FindMin(int[] arr)
{
    int len = arr.Length;
    int min = arr[0];
    for (int i = 0; i < len; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            i++;
        }
    }
    return min;
}

int Diff(int A, int B)
{
    int diff = 0;
    if (A < B)
    {
        diff = B - A;
    }
    else
    {
        diff = A - B;
    }
    return diff;
}

Console.WriteLine($"Введите желаемое количество чисел - ");
int Z =  int.Parse(Console.ReadLine());
Console.WriteLine("````");

int[] col = CreateArr(Z);
FillArr(col);
PrintArr(col);

int A = FindMax(col);
Console.WriteLine("````");
Console.WriteLine($"Максимальное число - {A}");

int B = FindMin(col);
Console.WriteLine("````");
Console.WriteLine($"Минимальное число - {B}");

int C = Diff(A, B);
Console.WriteLine("````");
Console.WriteLine($"Разница мин- го и макс- го чисел - {C}");

