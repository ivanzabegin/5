// Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
 
static int RecursiveMethod(int m, int n)
{
    
    if (m == n)
    {
        return m;
    }
    else 
    {
        return m + RecursiveMethod(m + 1, n);
    }
}

Console.WriteLine(RecursiveMethod(0 ,4));
   