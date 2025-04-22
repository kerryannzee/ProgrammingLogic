namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1
      string[] seasons = {"Spring", "Summer", "Fall", "Winter"};
      foreach (string i in seasons) 
      {
        Console.WriteLine(i);
      } 
      
    //Problem 2
       string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

       Console.Write("Enter a number from 1 to 7: ");
       string input = Console.ReadLine();
       
       bool isValid = int.TryParse(input, out int dayNumber);

       if (isValid && dayNumber >= 1 && dayNumber <= 7)
       {
         Console.WriteLine("The day is: " + days[dayNumber - 1]);
       }
       
       else
       
       {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
       }
       
    //Problem 3
       string[] books = { "The Last Silk Dress", "Holes", "The Giver" };

       string[] authors = { "Ann Rinaldi", "Louis Sachar", "Lois Lowry" };

       for (int i = 0; i < books.Length; i++)
       {
         Console.WriteLine($"{books[i]} by {authors[i]}");
       }
        
    //Problem 4
      int[] temperatures = { 65, 72, 78, 70, 68 };

      Array.Sort(temperatures);

      Console.WriteLine("Temperatures in ascending order:");
      foreach (int temp in temperatures)
      {
        Console.WriteLine(temp);
      }

      int lowest = temperatures[0];
      int highest = temperatures[temperatures.Length - 1];

      Console.WriteLine($"\nLowest temperature: {lowest}");
      Console.WriteLine($"Highest temperature: {highest}");
      
    //Problem 5
      int[] countdown = { 5, 4, 3, 2, 1 };

      Array.Reverse(countdown);

      Console.WriteLine("Reversed countdown:");
      for (int i = 0; i < countdown.Length; i++)
      {
         Console.WriteLine(countdown[i]);
      }
    
    }
}