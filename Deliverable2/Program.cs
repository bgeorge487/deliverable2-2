using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {

            string lastVisited = "";
            string userInput;
            string userOutput = "";
            Console.WriteLine("What would you like to say to the bot?");


            while (true)
            {
                Console.Write("User: ");
                userInput = Console.ReadLine().ToLower();
                
                if(userInput == lastVisited)
                {
                    Console.WriteLine("I’m sorry but you have already said that");
                    continue;
                }
                
                switch (userInput)
                {
                    
                    case "hello":
                        Console.WriteLine("Hello good to see you");
                        break;
                    case "sup":
                        Console.WriteLine("I am good");
                        break;
                    case "hello there":
                        Console.WriteLine("General Kenobi");
                        break;
                    default:
                        if (userInput == "bye")
                        {
                            Console.WriteLine("Good Bye!");
                            return;
                        }
                        break;
                }

                lastVisited = userInput;
                Console.WriteLine(userOutput);
            }


            //Console.WriteLine(userInput);



        }
    }
}
