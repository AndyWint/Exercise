// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [-4, -6, 89, 6] -> 0
// [3, 7, 23, 12] -> 19

int []CreateArr(int len)
{
    return new int[len]; 
}

void FillArr(int []arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
    arr[i] = new Random().Next(-100, 100);
    }
}

void PrintArr(int []arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int Sum(int[]arr)
{
    int sum = 0;
    int len = arr.Length; 
    for(int i = 1; i < len; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int []col = CreateArr(7);
PrintArr(col);
Console.WriteLine("```");
Console.WriteLine("");
FillArr(col);
PrintArr(col);
Console.WriteLine("");
int A = Sum(col);
Console.WriteLine($"Сумма элементов при нечетном индексе - {A}");






