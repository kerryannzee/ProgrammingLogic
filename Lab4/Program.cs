﻿namespace Lab4;

      class Program
  {
    static void Main(string[] args)
    {
   //Problem 1
      for (int i = 0; i < 11; i++) 
      {
        Console.WriteLine(i);
      }    
  //Problem 2
      
      for (int i = 1; i <= 20; i++) 

      if (i % 2 == 0) 
      {
        Console.WriteLine(i);
      }
      
  //Problem 3
      int j = 5;

      while (j >= 1)
      {
      Console.WriteLine(j);
      j--; 
      }
      
  //Problem 4
      int number;

      do
      {
      Console.WriteLine("Please enter a number greater than 100:");
      number = Convert.ToInt32(Console.ReadLine());
      } while (number <= 100);

      Console.WriteLine($"You entered a valid number: {number}");
      
  //Problem 5
      int k = 10;

      while (k <= 1000)
      {
      Console.WriteLine(k);
      k += 10; // Increment by 10
      } 
      
  //Problem 6
      for (int l = 1; l <= 10; l++) // Outer loop controls the rows
      {
      for (int m = 1; m <= l; m++) // Inner loop controls the stars per row
      {
      Console.Write("*");
      }
      Console.WriteLine(); // Move to the next line after each row
      }
    }
  }
}