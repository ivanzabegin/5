int numberA = 8;
Console.WriteLine(numberA);
int numberB = 8;
Console.WriteLine(numberB);

if (numberA > numberB)
{
    Console.WriteLine("max=" + numberA);
    Console.WriteLine("min=" + numberB);
}

else if (numberA < numberB)
{
    Console.WriteLine("max=" + numberB);
    Console.WriteLine("min=" + numberA);
}

else if (numberA==numberB)

{
    Console.WriteLine("No max or min, equally. " +  numberA+"="+numberB);
}