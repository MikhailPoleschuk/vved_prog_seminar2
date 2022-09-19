// Введите 3 числа и посчитайте сумму только положительных чисел
int i = 0;
int Sum = 0;
while (i < 3)
{
    Console.WriteLine($"Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 0) { Sum = Sum + a; }
    i++;
}
Console.WriteLine(Sum);
