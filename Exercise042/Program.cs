// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.// 
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int[] CheckMax(int number1, int number2)
{
    int[] array = new int[2];
    while (array[0] == 0)
    {
        if (number1 > 0 & number2 > 0)
        {
            if (number1 > number2)
            {
                array[0] = number2;
                array[1] = number1;
            }
            else
            {
                array[0] = number1;
                array[1] = number2;
            }
        }
        else
        {
            if (number1 < 0)
            {
                number1 = 1;
            }
            else
            {
                number2 = 1;
            }
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int SumNaturalNumbers(int []array)
{
    int sum = 0;
    while (array[0] <= array[1])
    {
        sum = sum + array[0];
        array[0]++;
    }
    return sum;
}


int m = -10;
int n = 22;

PrintArray(CheckMax(m, n));
Console.WriteLine("`````");
int A = SumNaturalNumbers(CheckMax(m,n));
Console.WriteLine("Сумма элементов:");
Console.Write(A);








