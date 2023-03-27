/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
Console.WriteLine($"введите числа: ");
string input = Console.ReadLine()!;
string[] Num = input.Split()!;
int[] index = new int[Num.Length];

for (int i = 0; i < Num.Length; i++)
{
  index[i] = int.Parse(Num[i]);
}
int enter(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      count= count + 1;
    }
  }
  return count;
}
Console.WriteLine($"чисел больше 0 было введено: ");
Console.WriteLine(enter(index));
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
/*
Console.WriteLine($"ВВедите метку b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"ВВедите метку k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"ВВедите метку b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"ВВедите метку k2: ");
double k2 = int.Parse(Console.ReadLine()!);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;
Console.WriteLine($"прямые пересекутся в точке: x= {x}, y= {y} ");

*/