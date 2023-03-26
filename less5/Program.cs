/*
 Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
Console.WriteLine($"Задайте размер массива");
int size = int.Parse(Console.ReadLine())!;
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(100, 1000);
  Console.Write(array[i] + " ");
}
Console.WriteLine();
int chet = 0;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] % 2 == 0) chet = chet + 1;
}

Console.WriteLine($"Количество четных чисел: " + chet);
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine($"Задайте размер массива");
int size = int.Parse(Console.ReadLine())!;
int[] array = new int[size];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(10, 100);
  Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 1; i < array.Length; i = 2)
{
    sum += array[i];
}
Console.WriteLine(sum);



/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/