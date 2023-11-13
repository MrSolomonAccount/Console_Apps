/*
 Name: Mr.Solomon
 Class: Comp Sci 20s
 Description: this code deals with optional parameters (input)
 */
namespace Functions2
{
    public class functionsClass
    {
        // when writing the function, if the varaible does not have
        // an initial value like String word, it is mandatory
        // if the variable has an initial value like bool showStars=false
        // it is optional 
       static void customMessage(String word, bool showStars=false)
        {

            // with optional input, if the user sends an input, 
            // the variable will use the user's input
            // if the user does not send anything, 
            // the variable will use the initial(default) value
            if(showStars)
            {
                Console.WriteLine("****" + word + "****");
            }
            else {
                Console.WriteLine(word);
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter a word");
            String input = Console.ReadLine();
            customMessage(input);
            customMessage(input, showStars:true);
        }
    }
}