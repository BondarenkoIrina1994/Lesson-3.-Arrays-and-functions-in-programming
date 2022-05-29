// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.

void distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Расстояние между двумя точками равно {result}");
}
double CheckingForCorrectnes(string str)
{
while (true)
{
Console.WriteLine(str);
string num=Console.ReadLine();
    if (double .TryParse(num, out double number) == false)
        Console.WriteLine("Вы ввели не число. Для корректной работы программы введите число!!!");
    else
    return number;
}
}
double x1 =CheckingForCorrectnes("Введите координату первой точки x1:");
double y1 =CheckingForCorrectnes("Введите координату первой точки y1:");
double z1 =CheckingForCorrectnes("Введите координату первой точки z1:");
double x2 =CheckingForCorrectnes("Введите координату второй точки x2:");
double y2 =CheckingForCorrectnes("Введите координату второй точки y2:");
double z2 =CheckingForCorrectnes("Введите координату второй точки z2:");

distance(x1, y1, z1, x2, y2, z2);
