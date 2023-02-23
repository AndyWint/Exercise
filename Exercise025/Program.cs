// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.



void Mass1(double[] strs)       //задает массив
{
    int n = strs.Length;
    int index = 0;
    while (index < n)
    {
        Console.Write("Введите число ");
        strs[index] = double.Parse(Console.ReadLine());
        index++;
    }

}

void PrintArray(double[] col)                  //выводит массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(" ");
        position++;
    }
}


double Result(double[] ar1, double[] ar2)       // считает расстояние и выводит результат
{
    double x1 = ar1[0];
    double y1 = ar1[1];
    double z1 = ar1[2];
    double x2 = ar2[0];
    double y2 = ar2[1];
    double z2 = ar2[2];
    double ac = y1 - y2;
    double bc = x1 - x2;
    double z = z1 - z2;
    double ab = Math.Sqrt(Math.Pow(ac, 2) + Math.Pow(bc, 2) + Math.Pow(z, 2));
    Console.WriteLine(" ");
    Console.WriteLine("Расстояние между точками ");
    Console.WriteLine(ab);
    return ab;
}


double[] strs = new double[3];
Console.WriteLine("Введите координаты первой точки ");
Mass1(strs);
PrintArray(strs);

Console.WriteLine(" ");

double[] strs2 = new double[3];
Console.WriteLine("Введите координаты второй точки ");
Mass1(strs2);
PrintArray(strs2);

Result(strs, strs2);










//Console.Write("Введите координаты второй точки ");

//number = 0;
//for (int index = 0; index < 3; index++)
//{
//    string A = Console.ReadLine();
//    number = double.Parse(A);



//double x1 = 3;
//double x2 = 2;
//double y1 = 6;
//double y2 = 1;
//double z1 = 8;
//double z2 = -7; 
// ((x1-x2)^2+(y1-y2)^2+(z1-z2)^2)

//double ac = y1 - y2;
//double bc = x1 - x2;
//double z = z1 - z2;

//double ab = Math.Sqrt(Math.Pow(ac, 2) + Math.Pow(bc, 2) + Math.Pow(z, 2)); 
//Console.WriteLine(ab);

