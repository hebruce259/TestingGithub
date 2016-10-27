using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {   //Ask user for name

            Console.WriteLine("Welcome! What is your name?");
            string input = Console.ReadLine();

            //Prompt user to determine if they would like to play a game

            Console.WriteLine("Would you like to play a game? Enter yes or no.");
            string yes = Console.ReadLine();

            if (yes == "y")
            {

            
            //If so Great!

            Console.WriteLine("Excellent!");

            //initialzie
            int state = 1;

            //as long as the user wants to play this will happen
            while (yes == "y" || yes == "yes")

                    switch (state)
                    {

                        case 1:

                            Console.WriteLine("You are walking across a field and you encounter a fire-breathing dragon!");
                            Console.WriteLine("What would you do? Choose Face the Beast or Run away.");
                            string FacetheBeast = Console.ReadLine();

                            break;

                        // state = 2;
                        // string RunAway = Console.ReadLine();

                        //  Console.WriteLine(RunAway);
                        // state = 6;

                        //break;

                        case 2:
                            Console.WriteLine("Enter 1, 2, or 3");
                            int numHeads = int.Parse(Console.ReadLine());
                            Console.WriteLine("No one has ever faced a " + numHeads + " headed dragaon before!");
                            state = 3;
                            break;
                        case 3:
                            Console.WriteLine("Choose your weapon.");
                            Console.WriteLine("Enter Slingshot, Sword, or Bow and Arrow");
                            state = 4;
                            // yes = "n";
                            break;

                        default:

                            break;
                    }

                }
            // string no = Console.ReadLine();
            //Console.WriteLine("Goodbye!");
        }
    }
}
