// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// да хоть минус пять



Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(a);
Console.WriteLine(" ");
int[] arr = new int[a * -1 + 1];


void FillArray(int[] collection)            //заполняем массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = index;
        index++;
    }
}

void PrintArray(int[] col)                  //выводит массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(" ");
        position++;
    }
}

void Cube(int[] arr)                         //возводим в куб и выводим в консоль
{

    int count = arr.Length;
    int i = 0;
    int pos = 0;
    while (i < count)
    {
        pos = arr[i];
        int col = pos * pos * pos;
        Console.WriteLine(col);
        i++;
    }
}

FillArray(arr);
PrintArray(arr);
Cube(arr);









