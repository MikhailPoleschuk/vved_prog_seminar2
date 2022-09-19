// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

int poiskchisla3(int ishodnik)
{
    while (ishodnik > 100) ishodnik = ishodnik - 100;
    // Console.Write($"сотые {ishodnik}");
    while (ishodnik > 10) ishodnik = ishodnik - 10;
    //result = ishodnik;
    return ishodnik;
}


Console.Write("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 100)
{
    Console.Write("Третьей цифры нет, пожалуйста, попробуйте заного :)");
}
else
{
    int chislo = -1;
    int n = x;
    while (n > 1000) n = n / 10;
    chislo = poiskchisla3(n);
    Console.Write($"Третьей цифра {chislo}");
}
