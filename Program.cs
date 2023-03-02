using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Введите а");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите а");
double c = Convert.ToDouble(Console.ReadLine());

double b2 = Math.Pow(b, 2);
double d = b2 - 4 * a * c;
Console.WriteLine($"Дискриминант = {d}");
double d2 = Math.Sqrt(d);
if (d > 0)
{
    double x1 = (-b + d2) / (2 * a);
    Console.WriteLine($"x1 = {x1}");
    double x2 = (-b - d2) / (2 * a);
    Console.WriteLine($"x2 = {x2}");
}
else if (d == 0)
{
    double x12 = (-b + d2) / (2 * a);
    Console.WriteLine($"x1 = {x12}");
}
else
    Console.WriteLine("Корней нет");
double x0 = -b / (2 * a);
double y0 = a * Math.Pow(x0, 2) + b * x0 + c;
Console.WriteLine($"Координаты вершины - ({x0},{y0})");
if (a > 0)
    Console.WriteLine("Ветви направлены вверх");
else if (a < 0)
    Console.WriteLine("Ветви направлены вниз");
if (a > 0)
    Console.WriteLine($"Минимальное значение = {y0}");
else if (a < 0)
    Console.WriteLine($"Максимальное значение = {y0}");
if (a > 0)
    Console.WriteLine($"Убывает от -бесконечности до {-x0}; Возрастает от {-x0} до +бесконечности");
else if (a < 0)
    Console.WriteLine($"Возрастает от -бесконечности до {-x0}; Убывает от {-x0} до +бесконечности");
if (d <= 0 & a > 0)
    Console.WriteLine($"Функция всегда положительна");
else if (d <= 0 & a < 0)
    Console.WriteLine($"Функция всегда отрицательна");