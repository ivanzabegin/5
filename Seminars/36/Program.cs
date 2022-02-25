// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечётных/чётных чисел.

Console.Clear();

int [] array = new int[4];

static void FillArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(100, 1000);
    }
}
FillArray(array);

static void PrintArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]}  ");
    }
}
PrintArray(array);

int even = 0;
int notEven = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array [i] % 2 == 0) even = even + 1;
    else notEven = notEven + 1;
}
Console.WriteLine($"в заданном массиве сумма положительных чисел= {even}, а отрицательных= {notEven}");
Console.WriteLine();