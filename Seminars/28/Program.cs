// Подсчитайте сумму цифр в числе.

Console.Clear();
Console.WriteLine("введи число: ");
int a = int.Parse(Console.ReadLine());
            int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
 
            }
 Console.WriteLine(s);
Console.WriteLine();