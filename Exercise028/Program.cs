// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Number(string mes)
{
    Console.WriteLine(mes);
    int A = int.Parse(Console.ReadLine());
    return A;
}

int Sum(int number)
{
    int res = 0;
    while (number > 0)
    {
        res = res + number % 10;
        number = number / 10;
    }
    return res;

}
void Print(int A)
{
    Console.WriteLine(A);
}

int A = Number("Введите число");
Print(Sum(A));
