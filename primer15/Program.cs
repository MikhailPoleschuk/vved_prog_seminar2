// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6->да
//7->да
//1->нет


Console.Write("Введите день недели от 1 до 7:");
int num_day;
num_day = Convert.ToInt32(Console.ReadLine());
if (num_day > 7 || num_day < 1)
{
    Console.Write("не верное число, введите число от 1 до 7 ");
}
else if (num_day == 6 || num_day == 7)
{
    Console.Write("Выходной! :)");
}
else
{
    Console.Write("нет :(");
}