// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int numberA = -3;
int numberB = 8;

Console.Write("Большее число, ");
    if (numberA > numberB)
{
    Console.WriteLine(numberA);
}
    else 
{
    Console.WriteLine(numberB);
} 

Console.Write("Меньшее число, ");
    if (numberA < numberB)
{
    Console.WriteLine(numberA);
}
    else 
{
    Console.WriteLine(numberB);
}

 