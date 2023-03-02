// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ResultX(double b1, double b2 , double k1, double k2)
{
    double res = 0;
    double x = 0;
    double y = 0; 
    x = (b1 - b2) / (k2 - k1);
    y = k2 * x + b2;
    res = x;
    return res;
}

double ResultY(double b1, double b2 , double k1, double k2)
{
    double res = 0;
    double x = 0;
    double y = 0; 
    x = (b1 - b2) / (k2 - k1);
    y = k2 * x + b2;
    res = y;
    return res;
}





double A = ResultX(2, 4, 5, 9);
double B = ResultY(2, 4, 5, 9);
Console.WriteLine($"Координаты пересечения: ({A} , {B})");


