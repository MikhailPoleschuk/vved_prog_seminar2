//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Введите 3х значное число:");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 100 || x > 999)
{
    Console.Write("Вы ввели не трехзначное число, пожалуйста, попробуйте заного :)");
}
else
{
    int N = x;
    while (N > 100) N = N - 100;
    int dv = N;
    while (N >= 10) N = N - 10;
    int Edinicy = N;
    int itog = (dv - Edinicy) / 10;
    Console.Write(itog);
}
