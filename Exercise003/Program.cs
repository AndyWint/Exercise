﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

//  4 -> да
// -3 -> нет
//  7 -> нет

double A = -2;
double div = 0;
div = A % 2;
if(div == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

