// 16
Console.WriteLine($"Введите Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b || b == a*a) {Console.Write($" да");}
else {Console.Write($" нет");}