/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


using static System.Console;
Clear();

Write("Задайте значение N: ");
int firstSum = Convert.ToInt32(ReadLine());
Write("Задайте значение M: ");
int lastSum = Convert.ToInt32(ReadLine());
int sum = Sum(firstSum, lastSum);
WriteLine(sum);

int Sum(int number1, int number2)
{
    if (number1 > number2)
    {
        if (number1 == number2)
            return number2;
        return number1 + Sum(number1 - 1, number2);
    }
    else
    {
        if (number1 == number2)
            return number1;
        return number2 + Sum(number1, number2 - 1);
    }
}
