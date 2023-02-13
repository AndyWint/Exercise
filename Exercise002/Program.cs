//Напишите программу, 
//которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a, b, c;
        
a = 44;
b = 5;
c = 78;

int max1, max2;
max1 = 0;
max2 = 0;
        
    if (a < b)
        {
            if (b < c)
            {
                max2 = c;
            }
            else
            {
                max2 = b;
            }
        }
    else
        {
            if (a < c)
            {
                max1 = c;
            }
            else
            {
                max1 = a;
            }
        }
    if (max1 < max2)
        {
            Console.Write(max2);
        }
    else
        {
            Console.Write(max1);
        }


