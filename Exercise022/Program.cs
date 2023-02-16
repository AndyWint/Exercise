// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int TrdNum(int b)
{
    if (b > 1000)
    {
        while (b > 1000)
        {
            b = b / 10;
        }
        b = b % 10;
        return b;
    }
    else
    {
        if (b < 100)
        {
            Console.Write("Третьей цифры нет, ");
            b = 0;
            return b;
        }
        else 
        {
            b = b % 10;
            return b;
        }
        
    }    
}

int num = 631234235;
int result = TrdNum(num);
Console.WriteLine(result);

