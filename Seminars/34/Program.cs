// Написать программу для замены элементов массива на противоположные.

public class SamplesArray1  {

   public static void Main()  
   {
      int[] intArray = new int[9] {1,2,3,4,5,6,7,8,9};
      Console.WriteLine( "The Array initially contains the following values:" );
      PrintIndexAndValues( intArray );

      Array.Reverse( intArray);


      Console.WriteLine( "After reversing:" );
      PrintIndexAndValues( intArray );
   }

   public static void PrintIndexAndValues( Array intArray )  {
      for ( int i = intArray.GetLowerBound(0); i <= intArray.GetUpperBound(0); i++ )
         Console.WriteLine( "\t[{0}]:\t{1}", i, intArray.GetValue( i ) );
   }
}
