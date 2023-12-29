class ExceptionTestClass
{
   public static void Main()
   {
      int x = 0;
      try
      {
         int y = 100 / x;
      }
      catch (ArithmeticException e)
      {
         Console.WriteLine($"ArithmeticException Handler: {e}");
      }
      catch (Exception e)
      {
         Console.WriteLine($"Generic Exception Handler: {e}");
      }
   }	
}