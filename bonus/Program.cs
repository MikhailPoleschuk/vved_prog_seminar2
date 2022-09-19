// в какой греппе возраста вы находитесь
Console.WriteLine($"Введите Ваш возраст: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<12) {Console.Write($"ребенок");}
else if (a<21) {Console.Write($"подросток");}
else if (a<65) {Console.Write($"взрослый");}
else if (a<85) {Console.Write($"пожилой");}
else {Console.Write($"долгожитель");}
