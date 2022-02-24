// Задать номер четверти, показать диапазоны для возможных координат.

Console.Clear();

Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("Координаты: от 0 до 10.");
}
else if (num == 2) 
{
    Console.WriteLine("Координаты: от 10 до 100.");
}
else if (num == 3) 
{
    Console.WriteLine("Координаты: от 100 до 1000.");
}
else if (num == 4) 
{
    Console.WriteLine("Координаты: от 1000 до 10000.");
}
else
{
    Console.WriteLine("Не четверть");
}
