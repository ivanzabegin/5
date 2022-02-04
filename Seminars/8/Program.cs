// Показать четные числа от 1 до N
int number = 1;
while (number <= 100)
{
if (number%2==0)
{
Console.WriteLine("четное " + number);
number++;
}
else
{
number++;
}
}