// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y.

Console.Clear();

bool z1 = true;
bool z2 = true;
bool z3 = true;
bool z4 = true;

bool x = true;
bool y = true;

if (!(x || y) == (!x && !y))
{
    z1 = true;
}
x = false;
y = false;

if (!(x || y) == (!x && !y))
{
    z2 = true;
}
x = true;
y = false;

if (!(x || y) == (!x && !y))
{
    z3 = true;
}
x = false;
y = true;

if (!(x || y) == (!x && !y))
{
    z4 = true;
}
if (z1 && z2 && z3 && z4) Console.WriteLine("Является истиной");
else
{
Console.WriteLine("Не является истиной");
}
