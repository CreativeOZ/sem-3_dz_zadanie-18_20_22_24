// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y.

Console.Clear();

bool x = true;
bool y = true;

if (!(x || y) == (!x && !y))
Console.WriteLine("Является истиной");
else
Console.WriteLine("Не является истиной");