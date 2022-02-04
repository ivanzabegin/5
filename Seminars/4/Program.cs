int numberA = new Random().Next(1, 10);
int numberB = new Random().Next(1, 10);
int numberC = new Random().Next(1, 10);
Console.WriteLine(numberA);
Console.WriteLine(numberB);
Console.WriteLine(numberC);

int Max(int numberA, int numberB, int numberC)
{
    int result = numberA;
    if (numberB > result) result = numberB;
    if (numberC > result) result = numberC;
    return result;
}
Console.WriteLine( 'Max');
