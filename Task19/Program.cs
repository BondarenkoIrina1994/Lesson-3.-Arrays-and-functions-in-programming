// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void  Palindrom (string temp)
{
   
    if ((temp[0]==temp[4]) && (temp[1]==temp[3]))
         Console.WriteLine("Введенное число-палиндроп!!!");
   else 
         Console.WriteLine("Введенное число не является палиндропом!!!"); 
}

Console.WriteLine("Введите пятизначное число: ");
string number=Console.ReadLine();
int lenght=number.ToString().Length;

if(int.TryParse(number, out int num))
{
    if(lenght==5)
    Palindrom (number);
    else 
    Console.WriteLine("Некорректное значение!!! Введите пятизначное число: ");
}
else 
    Console.WriteLine("Вы ввели не число. Для корректной работы программы введите пятизначное число число!!!");
