



using System;



namespace Conditional_Statements

{

    class Program

    {

        static void Main(string[] args)

        {



            Console.WriteLine("How Many Years of Experience do you have in Professional Programming?");



            try

            {

                

                string Experience = Console.ReadLine();

                
                int YOE = 0;

                YOE = int.Parse(Experience);

                switch (YOE)

                {
                    case 0:

                        Console.WriteLine("Need Lots of Practice");
                        Console.WriteLine("Press any key to exit the program ...");

                        Console.ReadKey(true);
                        break;

                    case 1:

                        Console.WriteLine("Looks Like you have little experience");
                        Console.WriteLine("Press any key to exit the program ...");

                        Console.ReadKey(true);
                        break;

                    case 2:

                        Console.WriteLine("Wow! you have been doing this for a while");
                        Console.WriteLine("Press any key to exit the program ...");

                        Console.ReadKey(true);
                        break;

                    default:

                        Console.WriteLine("You are an Expert");
                        Console.WriteLine("Press any key to exit the program ...");

                        Console.ReadKey(true);
                        break;



                }
            }

            catch

            {

                Console.WriteLine("Please use a integer data type for your experience next time...");

                Console.WriteLine("Press any key to exit the program and try again...");

                Console.ReadKey(true);

            }
        }
    }
}