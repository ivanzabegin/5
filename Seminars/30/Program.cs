// Покажите кубы чисел, заканчивающихся на чётную цифру.

public class SamplesArray
{
    public static void Main()
    {
        
        int[] intArray = new int[5];

        for (int i = 0; i < intArray.Length; i++)
    {
        intArray [i] = new Random().Next(1, 100);
    }

        
        Action<int> action = new Action<int>(ShowCubed);

        Array.ForEach(intArray, action);
    }

    private static void ShowCubed(int val)
    {
        Console.WriteLine("{0:d} cubed = {1:d}", val, val*val*val);
    }
}