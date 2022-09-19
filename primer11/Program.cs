// 11 вывод случайного целого трехзначного числа, удаляем второе и пишем итоговое двузначное
int x= new Random().Next(100,1000);
Console.WriteLine(x);
int N=x;
while (N > 100) N=N-100;
int dv = N;
while (N>=10) N=N-10;
int Edinicy = N;
int desytky = (dv-N)/10;
int Sotny = (x - dv)/100;
int itog = Sotny*10 + Edinicy;
Console.WriteLine($"Единицы {Edinicy}");
Console.WriteLine($"Десятки {desytky}");
Console.WriteLine($"Сотни {Sotny}");
Console.WriteLine($"Итог {itog}");






