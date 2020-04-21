using System;
using System.Reflection.Metadata.Ecma335;

namespace DecisionMakingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            while (goOn == true)
            {
                Console.WriteLine($"{name} please enter a number between 1 and 100.");
                int i = int.Parse(Console.ReadLine());
                bool keepAsking = true;
            
                if (i <= 0 || i > 100)
                {
                    Console.WriteLine($"{name} that is not a valid answer");
                    while (keepAsking)
                    {
                        Console.WriteLine($"Would you like to try again {name}? Y/N");
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == "y")
                        {
                            keepAsking = false;
                            goOn = true;
                        }

                        else if (answer.ToLower() == "n")
                        {
                            Console.WriteLine("Goodbye");
                            keepAsking = false;
                            goOn = false;
                        }

                        else
                        {
                            Console.WriteLine($"{name} I didn't understand try again");
                        }
                    }
                }

                else if (i >= 60 && i % 2 != 0)
                {
                    Console.WriteLine($"{name} {i} is a odd");
                    while (keepAsking)
                    {
                        Console.WriteLine($"Would you like to try again {name}? Y/N");
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == "y")
                        {
                            keepAsking = false;
                            goOn = true;
                        }

                        else if (answer.ToLower() == "n")
                        {
                            Console.WriteLine("Goodbye");
                            keepAsking = false;
                            goOn = false;
                        }

                        else
                        {
                            Console.WriteLine($"{name} I didn't understand try again");
                        }
                    }
                }

                else if (i > 60 && i % 2 == 0)
                {
                    Console.WriteLine($"{name} {i} is a even");
                    while (keepAsking)
                    {
                        Console.WriteLine($"Would you like to try again {name}? Y/N");
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == "y")
                        {
                            keepAsking = false;
                            goOn = true;
                        }

                        else if (answer.ToLower() == "n")
                        {
                            Console.WriteLine("Goodbye");
                            keepAsking = false;
                            goOn = false;
                        }

                        else
                        {
                            Console.WriteLine($"{name} I didn't understand try again");
                        }
                    }
                }

                else if (i <= 60 && i>= 26 && i % 2 == 0)
                {
                    Console.WriteLine($"{name} that is even");
                    while (keepAsking)
                    {
                        Console.WriteLine($"Would you like to try again {name}? Y/N");
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == "y")
                        {
                            keepAsking = false;
                            goOn = true;
                        }

                        else if (answer.ToLower() == "n")
                        {
                            Console.WriteLine("Goodbye");
                            keepAsking = false;
                            goOn = false;
                        }

                        else
                        {
                            Console.WriteLine($"{name} I didn't understand try again");
                        }
                    }
                }

                else if (i >= 2 && i <= 25 && i % 2 == 0)
                {
                    Console.WriteLine($"{name} that is even and less than 25");
                    while (keepAsking)
                    {
                        Console.WriteLine($"Would you like to try again {name}? Y/N");
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == "y")
                        {
                            keepAsking = false;
                            goOn = true;
                        }

                        else if (answer.ToLower() == "n")
                        {
                            Console.WriteLine("Goodbye");
                            keepAsking = false;
                            goOn = false;
                        }

                        else
                        {
                            Console.WriteLine($"{name} I didn't understand try again");
                        }
                    }
                }

                else if (i % 2 != 0)
                {
                    Console.WriteLine($"{name} {i} is a odd");
                    while (keepAsking)
                    {
                        Console.WriteLine($"Would you like to try again {name}? Y/N");
                        string answer = Console.ReadLine();
                        if (answer.ToLower() == "y")
                        {
                            keepAsking = false;
                            goOn = true;
                        }

                        else if (answer.ToLower() == "n")
                        {
                            Console.WriteLine("Goodbye");
                            keepAsking = false;
                            goOn = false;
                        }

                        else
                        {
                            Console.WriteLine($"{name} I didn't understand try again");
                        }
                    }
                }
            }

        }
    }
}
