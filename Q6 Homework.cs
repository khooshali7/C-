using System;
class Program
{
    public static void Main(string[] args)
    {
        int n = 5;
      for (int i=n; i >= 1; i--)
      {
        for (int j=1; j<=i; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }
}
