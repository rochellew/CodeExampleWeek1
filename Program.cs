/**
 * 
 * This class demonstrates C# basics as outlined
 * in the course schedule for CSCI 2910
 * 
 */
public class Program
{
    // notice Main is capitalized (methods in C# use Pascal-case)
    static void Main(string[] args)
    {
        /*
         * Console operations, input and output, comments
         */

        // Console.WriteLine is synonymous with System.out.println
        Console.WriteLine("Hello!");

        // Console.ReadLine is synonymous with Scanner.NextLine
        Console.Write("Enter your name: ");

        // ?? is the null operator -- will set 'name' equal to "n/a"
        // if Console.ReadLine() is null
        string name = Console.ReadLine() ?? "n/a";

        // Read in a number -- need to parse (convert) the string that is 
        // read in with the ReadLine method
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        //int age = Int32.Parse(Console.ReadLine());

        /*
         * String interpolation & string concatenation
         */

        // String concatenation -- uses concatenation operator to
        // join strings and variables
        Console.WriteLine("Your name is " + name + ", and you are " + age + " years old.");

        // String interpolation -- uses interpolation to include
        // variables inside the string itself -- needs $ outside the string.
        // strings are character arrays -- notice name[0] will give me the first letter
        Console.WriteLine($"Your name is {name}, your first initial is {name[0]}, and you are {age} years old.");

        // notice the camel case on canOrder -- variables in C#
        // use camel case
        bool canOrder;

        if (age >= 21)
        {
            canOrder = true;
        }
        else
        {
            canOrder = false;
        }

        /**
         * Strings and characters
         */
        string message = "The quick brown fox jumped over the lazy dog.";
        char firstLetter = message[0];
        // last index is 1 less than the array's length because indexes start at 0
        char lastLetter = message[message.Length - 1];

        // 2 ways to declare and initialize arrays
        int[] numbers = { 12, 14, 16, 18, 20, 22 };
        string[] names = new string[3];

        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{num1} + {num2} = {Sum(num1, num2)}");

        Console.WriteLine("Generating a random number....");
        // we don't need to import Random because it is included in C# by default
        Random rand = new Random();
        Console.WriteLine(rand.Next());

    }// end Main

    static int Sum(int num1, int num2)
    {
        return num1 + num2; 
    }
}