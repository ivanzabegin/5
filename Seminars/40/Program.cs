// В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

Console.Clear();
double [] array = new double[5];

static void FillArray(double [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv [i] = new Random().Next(-100, 100);
    }
}
FillArray(array);

static void PrintArray(double[]massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]}  ");
    }
}
PrintArray(array);
Console.WriteLine();

double boxMax = 0;
double boxMin = 0;
double result = 0;

for (int i = 0; i < array.Length; i++)
{
    
    if (boxMin>array[i]) boxMin = array[i];
    if (boxMax<array[i]) boxMax = array[i];
    
    
}

Console.WriteLine(boxMin);
Console.WriteLine();
Console.WriteLine(boxMax);
Console.WriteLine();
Console.WriteLine(result = boxMax - boxMin);