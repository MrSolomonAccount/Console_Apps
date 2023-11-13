using System.Reflection.Metadata;

/*
 Name: Mr.Solomon
 Class: Comp sci 20s
 Description: this code deal with functions, mandatory and optional parameters
 */ 
namespace Functions
{
    public class FunctionsClass
    {
        // void means empty return
        // a void function does not return anything
        static void customMessage(String word)
        {
            Console.WriteLine("****"+word+"****");
        }

        // this function takes num1 and num2
        // and returns their sum
        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int product(int num1, int num2)
        {
            return num1 * num2;
        }

        static String toLowerOrUpper(String word, bool tolower)
        {
            if(tolower) {
                return word.ToLower();
            }
            else
            {
                return word.ToUpper();
            }
        }

       public static void Main()
        {
            Console.WriteLine("Please enter a word");
            String input = Console.ReadLine();
            
            // we call functions by their names and () to it
            // if the function takes input, we put the input between ()
            customMessage(input);
            customMessage(input);
            // the function executes every time we call it

            ///////////////////////////////////////////////////////////////////////

            Console.WriteLine("Enter the first number");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int second = Convert.ToInt32(Console.ReadLine());

            // when a function returns a value
            // we can store that value in a variable to use it later
            int result = sum(first, second);
            Console.WriteLine("the sum is " + result);

            result= product(first, second);
            Console.WriteLine("the product is " + result);

            ////////////////////////////////////////////////////////

            Console.WriteLine("Enter a word");
            input = Console.ReadLine();
            String changedWord = toLowerOrUpper(input, true);
            Console.WriteLine(changedWord);

            changedWord = toLowerOrUpper(input, false);
            Console.WriteLine(changedWord);


        }
    }
}