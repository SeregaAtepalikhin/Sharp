/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
Console.Write($"Задайте стартовое значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int M = 1;
OutNumbers(n, M);

void OutNumbers(int n, int M)
{
  if (M > n)
  {
    return;
  }
  else
  {
    OutNumbers(n, M + 1);
    Console.Write(M + " ");
  }
}
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
Console.Write($"Задайте значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Задайте значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

SumNM(N, M);

void SumNM(int N, int M)
{
  Console.Write(SumNum(N - 1, M));
}
int SumNum(int N, int M)
{
  int result = N;
  if (N == M)
    return 0;
  else
  {
    N++;
    result = N + SumNum(M, N);
    return result;
  }
}
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
Console.Write($"Задайте значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Задайте значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

Akkerman(m, n);

void Akkerman(int m, int n)
{
  Console.Write(AkkermanF(m, n));
}

int AkkermanF(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0 && m > 0)
  {
    return AkkermanF(m - 1, 1);
  }
  else
  {
    return (AkkermanF(m - 1, AkkermanF(m, n - 1)));
  }
}
*/