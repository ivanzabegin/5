// Покажите кубы чисел, заканчивающихся на чётную цифру.

public class SamplesArray
{
static void PrintValues(int[] intArray)
{
foreach (int i in intArray)
{
Console.Write("\t{0}", i);
}
Console.WriteLine();
}

public static void Main()
{
int[] intArray = new int[5];
for (int i = 0; i < intArray.Length; i++)
{
intArray [i] = new Random().Next(1, 100);
}
PrintValues(intArray);
Action<int> action = new Action<int>(ShowCubed);
Array.ForEach(intArray, action);

}
private static void ShowCubed(int val)
{
if (val %2 ==0) Console.WriteLine("{0:d} cubed = {1:d}", val, val*val*val);
}
}