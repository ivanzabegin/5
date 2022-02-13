// Задача 22: Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Enter X1");
string point1 = Console.ReadLine();
Console.WriteLine("Enter Y1");
string point11 = Console.ReadLine();
Console.WriteLine("Enter X2");
string point2 = Console.ReadLine();
Console.WriteLine("Enter Y2");
string point22 = Console.ReadLine();
Console.WriteLine("Enter Z1");
string point3 = Console.ReadLine();
Console.WriteLine("Enter Z2");
string point33 = Console.ReadLine();
//Console.WriteLine(point1);
//Console.WriteLine(point2);
double point1_1 = Convert.ToDouble(point1);
double point11_1 = Convert.ToDouble(point11);
double point2_1 = Convert.ToDouble(point2);
double point22_1 = Convert.ToDouble(point22);
double point3_1 = Convert.ToDouble(point3);
double point33_1 = Convert.ToDouble(point33);
double dx = point1_1 - point11_1;
double dy = point2_1 - point22_1;
double dz = point3_1 - point33_1;
double result = Math.Sqrt(dx * dx + dy * dy + dz * dz);
Console.WriteLine(result);

