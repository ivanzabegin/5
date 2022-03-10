// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы


Console.Clear();

Console.WriteLine("Введите коэффициент b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
Console.WriteLine("lines parallel");
if (k1 * k2 == (-1))
Console.WriteLine("lines ortangular");
double x = 0;
double y =0;
x = (b2-b1)/(k1-k2);
y = k2 * x + b2;
Console.WriteLine($"координата х={x}, координата y={y}");
