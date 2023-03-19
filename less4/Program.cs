//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
Console.WriteLine("введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B: ");
int B = int.Parse(Console.ReadLine());



int result = 1;
for (int i = 1; i <= B; i++)
{
  result = result * A;
}
Console.WriteLine(result);
*/
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("введите число : ");

int N = int.Parse(Console.ReadLine());
int length = 0;
int n = 0;

while (N > 0)
{
  n = N % 10;
  length = length + n;
  N = N / 10;
}
Console.WriteLine(length);

/*
int N;
Console.Write($"enter num: ");
int.TryParse(Console.ReadLine(), out N);

Console.Write($"{N} -> {sum(N)}");

int sum = 0;
for (int i = 1; i <= N; i++)
{
  sum += N % 10;
  N /= 10;
}

*/