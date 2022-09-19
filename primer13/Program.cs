// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.Write("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 100 )
{
    Console.Write("Третьей цифры нет, пожалуйста, попробуйте заного :)");
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
