//  Напишите метод, который задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Mass1(double[] strs)       //задает массив
{
    int n = strs.Length;
    int index = 0;
    while (index < n)
    {
        Console.Write("Введите число ");
        strs[index] = double.Parse(Console.ReadLine());
        index++;
    }
}

void PrintArray(double[] col)                  //выводит массив
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

//double A = Console.ReadLine("Введите число");     //  можно через эту переменную задать количество чисел в массиве
double[] arr = new double[5];
Mass1(arr);
PrintArray(arr);

