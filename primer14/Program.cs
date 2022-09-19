// 14
Console.WriteLine($"Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int ost1= a%7; // находим остаток от деления на 7
int ost2= a%23; // находим остаток от деления на 23
if (ost1>0 & ost1>0) {Console.Write($" нет");}
else {Console.Write($" да");}