// Показать двумерный массив размером m×n заполненный вещественными числами

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

static void FillArray(double[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
        }

    }
}
FillArray(array);

static void PrintArray(double[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {

            Console.Write($" \t{massiv[i, j]: 0.00}  ");
        
        }
Console.WriteLine();
    }
}
PrintArray(array);

