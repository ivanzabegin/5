//  Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран

Console.Clear();
int [] array = new int[8];
int [] array2 = new int [array.Length];
static void FillArray(int [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv [i] = new Random().Next(0, 2);
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
Console.WriteLine();