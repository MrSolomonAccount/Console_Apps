/*
 Name: Mr.Solomon
 Class: Comp Sci 20s
 Description: this code deals with loop statements
 */
namespace loops
{
    public class loopsClass
    {
        public static void Main()
        {
            /* int counter = 1;
             while(counter > 0) // this condition must be true for the loop
                 // to work at all
                 // the condition must become false at some point to prevent
                 // an inifinite loop
             {
                 Console.WriteLine(counter);
                 counter++;
             }*/

            /* bool keepRunning = true;
             string decision = "n";
             while (keepRunning)
             {
                 Console.WriteLine("This loop is running");
                 Console.WriteLine("Do you want to stop it? press y for yes or n for no");
                 decision = Console.ReadLine();

                 if(decision == "y") { keepRunning = false; }

             }*/


            // do while loops will always work at least one time
            // because it performs the action first, then checks the condition
            /* 
              do
              {
                  Console.WriteLine("This loop is working");
              } while (1 > 2); // regardless of whether it is true or false, the loop 
              // will work once

              // the condition needs to be true to run it more than once
              */

            /*
            int counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }while (counter <=10);
            */
            ///////////////////////////////////////////////////////////////////////////////////

            /*
                        // initialization is i=0
                        // boolean expression is i<10
                        // update is i++
                        // the loop will continue to work as long as the boolean
                        // expression is correct
                        for(int i=0; i< 10; i++)
                        {
                            Console.WriteLine(i+1);
                        }

                        // initialization i=10
                        // boolean expression is i<=100
                        // update is i+=10 which means i = i + 10
                        for(int i=10; i<=100; i += 10)
                        {
                            Console.WriteLine(i);
                        }

                        // counts down from 10 to 1
                        for(int i=10; i>=1; i--)
                        {
                            Console.WriteLine(i);
                        }

                        // an infinite loop because the 
                        // boolean expression never becomes false
                        for(int i=1; i>0; i++)
                        {
                            Console.WriteLine(i);
                        }*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////
            String[] names = { "Greg","Mann", "Magnus", "Martin" }; // array

            for(int i=0; i<names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            // there is a better way to loop through arrays
            foreach(String name in names){
                Console.WriteLine(name);
            }

            int[] numbers = { 10, 20, 30, 100 };
            foreach(int number in numbers){
                Console.WriteLine(number);
            }
        }
    }
}