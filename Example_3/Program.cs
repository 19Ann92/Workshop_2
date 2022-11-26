// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите цифру от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 6)
{
    Console.WriteLine("не выходной");
}
else if (6 <= num && num <= 7)
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("Число не соответствует дню недели");
}
