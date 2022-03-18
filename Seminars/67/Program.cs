// Показать натуральные числа от N до 1, N задано.

class RecExercise1
{
    static int printNatural(int ctr,int stval)
    {
	if (ctr < 1)
	{
	    return stval;
	}
	Console.Write(" {0} ",ctr);
		ctr--;
	return printNatural(ctr,stval);
    }
    
    static void Main()
    {
	
	Console.Write("Задать N : ");
	int ctr= Convert.ToInt32(Console.ReadLine());
	printNatural(ctr,1);
	Console.Write("\n\n");
    }
}
