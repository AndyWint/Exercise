// Перемешивание массива и ввод руками

// 1.Создать массив

int[] CreateArray(int length)
{
    return new int[length];
}



// Распечатать массив

void Print(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        Console.Write(array[index]);
        Console.Write(" ");
        ++index;
    }
}


// Заполнение 

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = index;
        index++;
    }
}


// Перемешивание

void Resort(int[] arr)
{
    int count = arr.Length - 1;
    int help = 0;
    int index = 0;
    while (count >= 1)
    {
        int rnd = new Random().Next(0, 999);   // Выбор случайного числа 
        index = rnd + 1;
        help = arr[index];
        arr[index] = arr[count];
        arr[count] = help;
        count--;
    }
}



int[] arr = CreateArray(1000);
FillArray(arr);
Print(arr);
Resort(arr);
Console.WriteLine();

Print(arr);


