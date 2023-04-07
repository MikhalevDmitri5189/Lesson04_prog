/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

int Start()
{
    Console.Write("Введите число: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}
int n = Start();
int Summ(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;

}
int result = Summ(n);
System.Console.WriteLine(result);