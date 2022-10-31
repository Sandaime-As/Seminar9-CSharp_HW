using static System.Console;
Clear();

Write("Введите значение числа N: ");
int num = Convert.ToInt32(ReadLine());
WriteLine(PrintNumbers(num));


string PrintNumbers(int n)
{
    return (n==1)? n.ToString(): n + " "+ PrintNumbers(n-1);
}