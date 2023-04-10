/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m, n;
Console.WriteLine("Введите число M:");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите число N:");
int.TryParse(Console.ReadLine(), out n);

Console.Write($"M = {m}; N = {n} -> ");
Console.Write($"{OutSum(m, n)}");


int OutSum(int m, int n)
{

    int sum = m;
    if (m >= n)
        return sum;
    return sum += OutSum(m + 1, n);
}
