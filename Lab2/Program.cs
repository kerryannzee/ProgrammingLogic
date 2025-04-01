namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
    //Part One
      int myNum = 171717;
      Console.WriteLine(myNum);
      
      double mypreciseNum = 0.173468D;
      Console.WriteLine(mypreciseNum);
      
      float mytinyNum = 0.017F;
      Console.WriteLine(mytinyNum);
      
      char myinitial = 'K';
      Console.WriteLine(myinitial);
      
      bool statement = true;
      Console.WriteLine(statement);
      
      string absurd = "onomonopia";
      Console.WriteLine(absurd);
      
    //Part Two
      double provideddecimal = 9.78;
	  int numberchanged = (int) provideddecimal; 
      Console.WriteLine(provideddecimal+ " is what I started with");   
      Console.WriteLine(numberchanged+ " is what I ended up with"); 
    
    //Part Three
      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();

      Console.WriteLine("What is your age?");
      int age = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Your name is " +name+ " and you are "+age);

    //Part Four
      int num1 = 6;
      int num2 = 7;

      int additionresult = num1 + 10;
      int subtractionresult = num2 - 2;
      int multiplicationresult = num1 * 3;
      int divisionresult = num2 / 2;
      int modulusresult = num1 % 2;

      Console.WriteLine("Addition: " +num1+ " + 10 = " +additionresult);
      Console.WriteLine("Subtraction: " + num2+ " - 2 = " +subtractionresult);
      Console.WriteLine("Multiplication: " +num1+ " * 3 = " +multiplicationresult);
      Console.WriteLine("Division: " + num2+ " / 2 = " +divisionresult);
      Console.WriteLine("Modulus: " + num1+ " % 2 = "  +modulusresult);

    //Part Five
      float boat = 1.123456789F;
      double trouble = 1.123456789D;
      
      Console.WriteLine(+boat+ " and " +trouble);
    //Part Six
      int digit = 10;
      digit++;
      Console.WriteLine(digit);
      digit--;
      Console.WriteLine(digit);
    }
}
