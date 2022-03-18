// Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? 
// Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰


namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int numb = Int32.Parse(Console.ReadLine());
            int groop = 0;
            for(int i= 1; i<=numb; i++)
            {
                if(i ==Math.Pow(2,groop))
                {
                    Console.WriteLine();
                    groop++;
                    Console.Write($"{groop}-я группа");
                }
                Console.Write($"{i,5}") ;
            }
            Console.ReadKey();
        }
    }
}