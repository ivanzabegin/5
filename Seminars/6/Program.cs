// Выяснить является ли число чётным
int numberA = new Random().Next(1,100);
Console.WriteLine(numberA);
if (numberA%2==0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}
