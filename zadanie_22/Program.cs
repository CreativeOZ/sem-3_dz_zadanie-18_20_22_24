// Найти расстояние между точками в пространстве 2D/3D.

Console.Clear();

Console.WriteLine("Введите координату х1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату х2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату z2: ");
int z2 = int.Parse(Console.ReadLine());

int num(int first, int second)
{
    int result = (second - first) * (second - first);
    return result;
}
int sum2D = num(x1, x2) + num(y1, y2);
{
Console.WriteLine("Расстояние между точками в 2D пространстве = " + Math.Sqrt(sum2D));
}
int sum3D = num(x1, x2) + num(y1, y2) + num(z1, z2);
{
Console.WriteLine("Расстояние между точками в 3D пространстве = " + Math.Sqrt(sum3D));
}

