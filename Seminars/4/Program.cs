int numberA = new Random().Next(int.MinValue, int.MaxValue);
int numberB = new Random().Next(int.MinValue, int.MaxValue);
int numberC = new Random().Next(int.MinValue, int.MaxValue);
Console.WriteLine(numberA);
Console.WriteLine(numberB);
Console.WriteLine(numberC);
int max = numberA;
if (numberB> max) max = numberB;
if (numberC> max) max = numberC;

Console.WriteLine("Max=" + max);
