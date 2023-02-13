// Напишите программу, которая на вход принимает число (N), 
//  на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

double index = 1;
double N = -7;
if (index < N)
{
while (index <= N)
{
    double div = index % 2;
    if(div == 0)
{
    Console.Write(index);
}
    index = index + 1;
}
}
else
{
while (index >= N)
{
    double div = index % 2;
    if(div == 0)
{
    Console.Write(index);
}
    index = index - 1;
}
}
