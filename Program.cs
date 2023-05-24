//Задание 10
Console.Clear();
Console.WriteLine("Задание 10");
Console.Write("Число: ");
int number = int.Parse(Console.ReadLine());
int result = (number % 100) / 10;
Console.WriteLine(result);

//Задание 13
Console.WriteLine("Задание 13");
Console.Write("Число: ");
int num = int.Parse(Console.ReadLine());
if (num / 100 < 1)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
    string str = num.ToString();
    Console.WriteLine($"{num} -> {str[2]}");
}

//Задание 16
Console.WriteLine("Задание 16");
Console.Write("Число: ");
int num1 = int.Parse(Console.ReadLine());
if (num1 == 6 || num1 == 7)
{
    Console.WriteLine($"{num1} -> да");
}
else if (num1 < 1 || num1 > 7)
{
    Console.WriteLine($"Это не день недели");
}
else
{
    Console.WriteLine($"{num1} -> нет");
}