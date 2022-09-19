// случайное число отрезка 10,99 и показывает наибольшую цифру числа
int x= new Random().Next(10,100);
Console.WriteLine($"Нам выпало число {x}");
int N = x;
while (N>10) N=N-10;
int Edinica=N;
int Desytky=(x-N)/10;
if (Desytky==Edinica) 
{
    Console.WriteLine($"Цифры равны {Desytky} ");
}
else if (Desytky>Edinica)
{
Console.WriteLine($"Цифра {Desytky} больше");
}
else 
{
    Console.WriteLine($"Цифра {Edinica} больше");
}
