// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



void Wkd(int num)
{   
    if (num > 0 && num <= 7)
    {
        if (num == 6)
        {
            Console.WriteLine("Сегодня выходной!");
        }
        else if (num == 7)
        {
            Console.WriteLine("Сегодня выходной!");
        }
        else
        {
            Console.WriteLine("Пора идти на работу T-T");
        }
    }
    else
    {
        Console.WriteLine("Это не день недели, введите другое число");
    }

    
}
Console.Write("Введите день недели, ");
string enter = Console.ReadLine();
int a = Convert.ToInt32(enter);
Wkd(a);

