 //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void CubeNumbers(string number)
{
   if(int.TryParse(number, out int N))
   {
       if (N<=0)
       Console.WriteLine("Введите число больше 0");
       else
       {
        Console.WriteLine($"Значение кубов чисел от 1 до {number}:");
        for (int i=1 ; i <= N ; i ++) Console.Write($"{Math.Pow(i , 3)} ");
       }
   }
        else
        Console.WriteLine("Вы ввели не число. Для корректной работы программы введите число!!!");
   
}
Console.WriteLine("Введите число: ");
string num=Console.ReadLine();
CubeNumbers(num);
