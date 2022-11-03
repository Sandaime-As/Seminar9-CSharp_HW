/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


using static System.Console;
Clear();

Write("Введите значение числа N: ");
int num = Convert.ToInt32(ReadLine());
WriteLine(PrintNumbers(num));

string PrintNumbers(int n)
{
    return (n == 1) ? n.ToString() : n + " " + PrintNumbers(n - 1);
}