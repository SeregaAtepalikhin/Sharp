/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
int a = 0;
Console.Write($"введите 5-тизначное число: ");
string vvod = Console.ReadLine()!;
a = int.Parse(vvod);

if (a <= 99999 & a >= 10000)
{
int aa = a / 1000;
int a1 = aa / 100;
int a2 = aa % 10;
int bb = a % 1000;
int b1 = bb / 100;
int b2 = bb % 10;

 if ((a1==b2)&(b2==a2))
  {
    Console.Write($"не палиндром");
  }

  else 
  {
    Console.Write($" палиндром");
  }
}
else
{
  Console.Write($"неверное число");
}

*/
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
/*
int x1, x2, y1, y2, z1, z2;
double d;
Console.Write("введите координаты х1 точки A: ");
int.TryParse(Console.ReadLine()!, out x1);
Console.Write("введите координаты y1 точки A: ");
int.TryParse(Console.ReadLine()!, out y1);
Console.Write("введите координаты z1 точки A: ");
int.TryParse(Console.ReadLine()!, out z1);
Console.Write("введите координаты х2 точки B: ");
int.TryParse(Console.ReadLine()!, out x2);
Console.Write("введите координаты y2 точки B: ");
int.TryParse(Console.ReadLine()!, out y2);
Console.Write("введите координаты z2 точки B: ");
int.TryParse(Console.ReadLine()!, out z2);

double x = Math.Pow((x2 - x1), 2);
double y = Math.Pow((y2 - y1), 2);
double z = Math.Pow((z2 - z1), 2);
d = Math.Sqrt(x + y + z);

Console.Write($"{d}");
*/
/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*

Console.WriteLine($"введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)  //1 стартовое число//
{
  Console.WriteLine($"куб числа {i} = {Math.Pow(i, 3)}");
}
*/
