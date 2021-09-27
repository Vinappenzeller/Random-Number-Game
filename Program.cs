using System;

namespace Lernatelier
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int Number = new Random().Next(1, 100);
                int Attempts = 1;               
                                         
                        Console.WriteLine("I thougt of a number. If you want to guess it type '1'");
                        Console.WriteLine("If you dont want to guess it type 0");
                        string input = Console.ReadLine();
                        int userNumber = Convert.ToInt32(input);

                if (userNumber != 1) 
                {
                    Environment.Exit(1);
                }

                Console.WriteLine("Please type in a number between 1 and 100");

                while (userNumber != Number)
                        {
                    try
                    {
                        if (Attempts == 1) 
                        {
                            input = Console.ReadLine();
                            userNumber = Convert.ToInt32(input);
                            Attempts++;
                        }
                        
                        while ((userNumber < 1) | (userNumber > 100))
                        {
                            Console.WriteLine("Error, your number needs to be between 1 and 100");
                            input = Console.ReadLine();
                            userNumber = Convert.ToInt32(input);
                        }

                        if (userNumber > Number)
                        {
                            Console.WriteLine("Your number is too high...");
                            input = Console.ReadLine();
                            userNumber = Convert.ToInt32(input);
                            Attempts++;
                        }
                        if (userNumber < Number)
                        {
                            Console.WriteLine("Your number is too small...");
                            input = Console.ReadLine();
                            userNumber = Convert.ToInt32(input);
                            Attempts++;
                        }
                    }catch
                    {
                        Console.WriteLine("That is not a number!  ");
                        Console.WriteLine("_______________________");
                        Console.WriteLine("Please type in a number");
                        input = Console.ReadLine();
                        userNumber = Convert.ToInt32(input);
                    }

                          }

                        Attempts++;
                if (Attempts > 2)

                {
                    Console.WriteLine("Amazing, you guessed the right number !! You had " + Attempts + " Attempts");           
                }

                else if (Attempts == 2)

                {
                    Console.WriteLine("Amazing, you guessed the number first try");
                }

                Console.WriteLine("If you want to play again type 'retry' ");

            } while (Console.ReadLine() == "retry");
            Environment.Exit(1);
        }
    }
} 