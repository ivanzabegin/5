// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

namespace Project_Console2
{
class Program
    {

    static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] arr = new int[m, n];
            Random row = new Random();
            int[] avg = new int[n];
            int sum = 0;
            int sr_z = 0;
            for (int j = 0; j < n; j++)
            {
                sum = 0;
                for (int i = 0; i < m; i++)
                {

                    arr[i, j] = row.Next(1, 10);
                    sum += arr[i, j]; 
                    
                }
                sr_z = sum / m; 
                avg[j] = sr_z; 
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");  
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("average for columns");
            for (int j = 0; j < n; j++) 
                Console.Write(avg[j] + " "); 

            Console.WriteLine("\n");
            Console.WriteLine();
        }
    }
}