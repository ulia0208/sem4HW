// НЕЛЬЗЯ РЕШАТЬ ЧЕРЕЗ MATH.POW
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число, которое будем возводить в степень!");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое будет степенью!");
int pow = Convert.ToInt32(Console.ReadLine());

int num2 = num;
int i=1;
while (i<pow)
{
    i++;
    num2=num2*num;
}
Console.WriteLine(num2);