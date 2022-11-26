// Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


int num = 32679;
string str = num.ToString();
int[] array = new int[str.Length];

for (int i = 0; i < str.Length; i++)
{
    array[i] = int.Parse(str[i].ToString());
}

if (num > 99)
{
   Console.WriteLine(array[2]);
}
else if (num <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}

