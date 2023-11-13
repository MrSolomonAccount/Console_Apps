/*
 Name: Mr. Solomon
 Class: Comp sci 20s
 Description: this code deals with switch statements which are
 conditional statetments
 */
namespace Switch_Statements
{
    public class Switches
    {
        public static void Main()
        {
            /* Console.WriteLine("Enter a number from 1 - 12");
             int month = Convert.ToInt32(Console.ReadLine());
             /*
             if(month == 1) { Console.WriteLine("January"); }
             else if(month == 2) { Console.WriteLine("February"); }
             else if(month == 3) { Console.WriteLine("March"); }
             else { Console.WriteLine("Invalid input"); }*/

            // switch helps us compare one variable (value) to multiple
            // other cases
            // here the variable month is compared to the numbers 
            // from 1 - 12
            /*  switch(month)
              {
                  case 1:  // compares month to 1, if equal executes the print statement
                      Console.WriteLine("January");
                      break; // break is needed to break out of the switch!
                  case 2:
                      Console.WriteLine("February");
                      break;
                  case 3:
                      Console.WriteLine("March");
                      break;
                  case 4:
                      Console.WriteLine("April");
                      break;
                  case 5:
                      Console.WriteLine("May");
                      break;
                  case 6:
                      Console.WriteLine("June");
                      break;
                  case 7:
                      Console.WriteLine("July");
                      break;
                  case 8:
                      Console.WriteLine("August");
                      break;
                  case 9:
                      Console.WriteLine("September");
                      break;
                  case 10:
                      Console.WriteLine("October");
                      break;
                  case 11:
                      Console.WriteLine("November");
                      break;
                  case 12:
                      Console.WriteLine("December");
                      break;
                  default: // only executes if all the above cases are false
                      Console.WriteLine("Invalid input");
                      break;      
              }*/

            Console.WriteLine("Enter your name to find out your grade");
            String name = Console.ReadLine();   

            switch (name.ToLower())
            {
                case "greg":
                    Console.WriteLine("85%");
                    break;
                case "magnus":
                    Console.WriteLine("88%");
                    break;
                case "mann":
                    Console.WriteLine("89%");
                    break;
                case "lochlan":
                    Console.WriteLine("90%");
                    break;
                default:
                    Console.WriteLine("I never met you in my life");
                    break;

            }


        }
    }
}