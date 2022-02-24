// Найти кубы чисел от 1 до N.

Console.Clear();

Console.Write("Ввести число N = ");
int num = int.Parse(Console.ReadLine());
int x = 1;
int y = 1;
while (x <= num)
{
    Console.Write(x+ " ");
    x++;
}
Console.WriteLine();
while (y <= num)
{
    Console.Write(y*y*y+ " ");
    y++;
}
