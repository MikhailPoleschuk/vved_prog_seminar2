// 12
int ost;
Console.WriteLine($"Введите Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>=b)
{
    ost= a%b;
}
else
{
    ost = b%a;
}
Console.Write($" Первое число {a}");
Console.Write($" Второе число {b}");
if (ost > 0) 
{
        Console.WriteLine($" не кратно остаток {ost}");
}
else 
{
    Console.WriteLine($" кратно");
}
