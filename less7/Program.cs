/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
Console.WriteLine($"Add m: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Add n: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[row, column];
FillArrayRandomNumbers(array);
PrintArray(array);

void FillArrayRandomNumbers(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToDouble(new Random().Next(-99, 99)) / 10;
    }
  }
}

void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j] ,5 }");
    }
    Console.WriteLine();
  }
}
FillArrayRandomNumbers(array);
PrintArray(array);
*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
Console.Write("Введите строку: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());
int n = 3; 
int m = 4; 
Random random = new Random();
int[,] array = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = random.Next(0, 10);
Console.Write("{0} ", array[i, j]);
}
Console.WriteLine();
}
    if (row < 0 | row > array.GetLength(0) | column < 0 | column > array.GetLength(1))
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", array[row, column]);
}
Console.ReadLine();
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
Random random = new Random();
int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    array[i, j] = random.Next(1, 10);
    Console.Write(array[i, j] + " ");
  }
  Console.WriteLine();
}
Console.WriteLine($"\n");

Console.WriteLine(array.GetLength(0));
for (int j = 0; j < array.GetLength(1); j++)
{
  double sum=0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    sum += array[i, j];
  }
  Console.WriteLine($"{ sum /array.GetLength(0)} ");
}
Console.ReadLine();

*/
