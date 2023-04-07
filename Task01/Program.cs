/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.WriteLine("Введите число A:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = int.Parse(Console.ReadLine());
int c = 1;
if (b < 1)
    Console.Write("Число B должно быть натуральным\n");
else
{
    while (b != 0)
    {
        c = c * a;
        b = b - 1;
    }
    Console.Write($"Число A в натуральной степени B равно {c}");
}