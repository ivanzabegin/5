// Задача 46: Написать программу масштабирования фигуры
/*Для тех, кто ушёл далеко вперёд, — усложнение.
Сделать так, чтобы:
1. Вершины фигуры задавались списком (в одну строку). Например: "(0,0) (2,0) (2,2) (0,2)".
2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
3. В результате были выводились полученные координаты.
При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)" */


Console.Clear();
Console.WriteLine("задать коэффициент масштабирования:");
double k = Convert.ToDouble(Console.ReadLine);
Console.WriteLine("введите координаты вершин фигуры, разделяя запятой:");
var input = Console.ReadLine().Split(',');
var myList = new List<int>(input.Select(int.Parse));

Console.WriteLine("начальная координата\tпосле масштабирования");
foreach (var item in myList)
{
    Console.WriteLine($"\t{item} \t\t\t\t{item*k: 0.0}");
}

Console.WriteLine();