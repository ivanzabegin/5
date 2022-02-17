// Возведите число А в натуральную степень B, используя цикл

Console.Clear();
Console.Write("введите число:"); 
int a = int.Parse(Console.ReadLine());
for (int power = 0; power <= 32; power++)
   {
       Console.WriteLine($"{a}^{power} = {(long)Math.Pow(a, power):N0}(0x{(long)Math.Pow(a, power):X})");
   }