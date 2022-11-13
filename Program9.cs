// Домашняя работа 9.
// Зачада 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
}

ShowNums(6);

// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNaturalElements(int m, int n)
{
    if (n < m) return n += SumNaturalElements(n + 1, m);
    if (n > m) return n += SumNaturalElements(n - 1, m);
    else return n;
}

Console.WriteLine(SumNaturalElements(1,4));

// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermanFunction(m - 1, 1);
  else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.WriteLine(AckermanFunction(3,2));