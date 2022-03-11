// Задать двумерный массив следующим правилом: Aₘₙ = m+n


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
            massiv[i, j] = i+j;
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


