// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

static void FillArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(-100,100);
        }

    }
}
FillArray(array);

static void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {

            Console.Write($" \t{massiv[i, j]}");
        
        }
Console.WriteLine();
    }
}
PrintArray(array);

Console.Write("Введите искомое число: ");
int f = int.Parse(Console.ReadLine());
bool check = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array [i,j]==f)
        {
            Console.WriteLine($"Число {f} находится на позиции {i}, {j}");
            check = true;
        }
    }
}
if (!check) Console.WriteLine("искомого нет");
