//  Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumberWithHands(string mes)
{
    Console.WriteLine(mes);
    int A = int.Parse(Console.ReadLine());
    return A;
}

int PowerWithHands(string mes)
{
    Console.WriteLine(mes);
    int B = int.Parse(Console.ReadLine());
    return B;
}

int Power(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }

    return result;
}

void Print(int A)
{
    Console.WriteLine(A);
}


Print(Power(NumberWithHands("Введите число"), PowerWithHands("Введите степень")));







