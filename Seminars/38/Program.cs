// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

Console.Clear();
int [] array = new int[7];

static void FillArray(int [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv [i] = new Random().Next(1, 10);
    }
}
FillArray(array);

static void PrintArray(int[]massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]}  ");
    }
}
PrintArray(array);

int summaUneven = 0;
int index = 0;
int box = 0;

for (int i = 0; i < array.Length; i++)
{
    if (index %2 !=0)
    summaUneven += array[i];
    index++;
}
Console.WriteLine();

Console.WriteLine(summaUneven);