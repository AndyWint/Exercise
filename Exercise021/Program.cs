// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecNum(int b)
{
    int result = (b / 10) % 10;
    return result;
}

int a = 678;
int number = SecNum(a);
Console.WriteLine(number);

