// Программа проверяет пятизначное число на палиндром
    

// string[] strs = new string[5];
// int n = strs.Length;
// int index = 0;
// while(index < n)
// {
//     Console.Write("Введите число     ", index + 1);
//     strs[index] = Console.ReadLine();
//     index++;
// }
//
// Console.WriteLine("Вы ввели следующие числа:");

int [] strs = new int[5];
strs[0] = 5;
strs[1] = 4;
strs[2] = 45;
strs[3] = 4;
strs[4] = 5;
//
//void PrintArray(int[] col)
//{
//    int count= col.Length;
//    int position = 0;
//    while(position < count)
//    {
//        Console.WriteLine(col[position]);
//        position++;
//    }
//}
//
//int Revert(int[] arr)
//{
//    int help = 0;
//    int index = 0;
//    int n = arr.Length;
//    while ( index < (n / 2))
//    {
//    help = arr[index];
//    arr[index] = arr [n - 1 - index];
//    arr[n - 1 - index] = help;
//    index++;
//    } 
//    return arr[index]; 
//}

//PrintArray(strs);
//Revert(strs);
//PrintArray(strs);


// if( PrintArray(strs) == Revert(strs))
// {
//    Console.WriteLine("Данное число является палиндромом");
// }
// else
// {
//    Console.WriteLine("Данное число не является палиндромом");
// }
int n = strs.Length;
int index = 0;
while (index < (n / 2))
{
    if (strs[4 - index] == strs[0 + index])
    {
        index++;
        
    }
    if (strs[4 - index] != strs[0 + index])
    {
        Console.WriteLine("Число не является палиндромом");
        break;
    }
    else 
    {
        Console.WriteLine("Число является палиндромом");
    }
}
