/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

using static System.Console;
Clear();

Write("Введите число m: ");
int firstNum = Convert.ToInt32(ReadLine());
Write("Введите число n: ");
int secondNum = Convert.ToInt32(ReadLine());
int Ackermann = AckermannFunction(firstNum, secondNum);
WriteLine($"A(m,n) = {Ackermann}");


int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}