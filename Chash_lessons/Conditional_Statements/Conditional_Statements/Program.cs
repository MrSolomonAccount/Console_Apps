/*
 Name: Mr. Solomon
 Class: Comp sci 20s
 Description: this code tells the user if their input is greater than 10 or not
 */
using static System.Formats.Asn1.AsnWriter;

namespace ConsoleApp1
{
    public class Hello
    {
        public static void Main()
        {

            /*Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
             // <= means less than or equal to
             // >= means greater than or equal to
             // != means not equal to


            //  < means less than
            if (num < 10)
            {
                Console.WriteLine("the number is less than 10");
            }
            // == means equal to
            else if(num == 10)
            {
                Console.WriteLine("the number is 10");
            }
            else 
            {
                Console.WriteLine("the number is greater than 10");
            }
            */
            /* Console.WriteLine("Enter your score");
             int score = Convert.ToInt32(Console.ReadLine());

             if (score >= 90) { 
                 Console.WriteLine("your grade is A");
             }
             else if (score >= 80) { 
                 Console.WriteLine("your grade is B"); 
             }
             else if (score >= 70) { 
                 Console.WriteLine("your grade is C"); 
             }
             else if (score >= 60) { 
                 Console.WriteLine("your grade is D");
             }
             else if (score >= 50) { 
                 Console.WriteLine("your grade is E");
             }
             else { 
                 Console.WriteLine("your grade is F");
             }
             */

            // boolean variables accept true or false values
            /* bool isSkyBlue = false;
             bool isFoodReady = false;

             // with the && (AND) operator, the statement only executes
             // if all conditions are true
             // True && False = False
             // False && True = False
             // False && False = False
             // True && True = True
             if(isSkyBlue && isFoodReady) { Console.WriteLine("Nice, we can go for the picnic"); }
             else { Console.WriteLine("Oh no, we can't go"); }
             */

            Console.WriteLine("Enter your grade to see if you're allowed on the field trip");
                   int grade = Convert.ToInt32(Console.ReadLine());

            // with || (OR) operator, only one condition needs to be true
            // False || False = False
            // True || False = True
            // False || True = True
            // True || True = True
            if(grade == 11 ||  grade == 12 )
            {
                Console.WriteLine("You can go on the field trip");
            }
            else { Console.WriteLine("No, you can not go on the field trip"); }

            ////////////////////////////////////////////////*
            if (grade != 11 && grade != 12)
            {
                Console.WriteLine("No, you can not go on the field trip");
            }
            else
            {
                Console.WriteLine("You can go on the field trip");
            }

        }
    }
}