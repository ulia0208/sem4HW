// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число");
Int64 num = Convert.ToInt32(Console.ReadLine());
Int64 n=0;
while (num>0)
{
   n=n+num%10;
   num=num/10;
}

Console.WriteLine(n);

