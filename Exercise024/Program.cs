// Программа проверяет пятизначное число на палиндром



string[] strs = new string[5];
int n = strs.Length;
int index = 0;
while (index < n)
{
    Console.Write("Введите число ");
    strs[index] = Console.ReadLine();
    index++;
}

Console.Write("Вы ввели следующие числа: ");


void PrintArray(string[] col)                  //выводит массив
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


string Pal(string[] strs)                      //присваивает значение правда ложь
{
    int n = strs.Length - 1;
    int index = 0;
    string B = " -1";
    while (index < n)
    {

        if (strs[n - index] == strs[0 + index])
        {
            index++;

        }
        if (strs[n - index] != strs[0 + index])
        {
            B = "False";
            break;
        }
        else
        {
            B = "True";
        }
    }


    return B;
}


void Trfs(string B)                        //выводит надпись 
{
    string A = B;
    if (A == "True")
    {
        Console.WriteLine(" Число является палиндромом");
    }
    else
    {
        Console.WriteLine(" Число не является палиндромом");
    }
}


PrintArray(strs);
Trfs(Pal(strs));