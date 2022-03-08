// Определить, сколько чисел больше 0 введено с клавиатуры.

Console.Clear();

Console.WriteLine("Введите 10 чисел:");
int[] a = new int[10];
int count = 0;
for (int i = 0; i < a.Length; i++)
{
a[i] = Convert.ToInt32(Console.ReadLine());
if (a[i] > 0) 
count++;
}
Console.WriteLine("чисел больше 0:  " + count);
