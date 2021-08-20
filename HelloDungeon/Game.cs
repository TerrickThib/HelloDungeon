using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //Start Screen
            string start = "Welcome To The Grungen";
           Console.WriteLine(start);
           
            //Name Exercise
            string name = "Empty";
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //varibles                      
            int currentArea = 1;
            string characterClass = "";
            int health = 100;           
            float power = 0;
            bool gameOver = false;


            //Fuction for Stats To display
            void DisplayStats()
            {
                Console.WriteLine(name + "stats:");
                Console.WriteLine("Class:" + characterClass);
                Console.WriteLine("Power" + power);
            }
            
            int GetInput(string description, string option1, string option2)
            {

            }
            string input = "";
            bool validInputReceived = false;

            while (validInputReceived == false)
               
            {
                //Class selection
                Console.WriteLine("Select a Class");
                Console.WriteLine("1.Knight");
                Console.WriteLine("2.Wizard");
                input = Console.ReadLine();
                
                //If class pick is knight            
                if (input == "1" || input == "Knight")
                {
                    characterClass = "Knight";
                    health = 100;
                    power = 10;
                    validInputReceived = true;
                }

                //If class pick is Wizard
                else if (input == "2" || input == "Wizard")
                {
                    characterClass = "Wizard";
                    health = 75;
                    power = 15;
                    validInputReceived = true;
                }
                //If neither are true
               else
               {
                    Console.WriteLine("Invalid Input"); 
               }
                
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Your Characters Stats\n");
            Console.WriteLine("Name " + name);
            Console.WriteLine("Class " + characterClass);
            Console.WriteLine("Health " + health);
            Console.WriteLine("Power " + power);
          
            //Number of attempts a Loop
            int numberOfAttempts = 4;

            Console.WriteLine("A very old man with a monkey on his back approches you." + "\n The monkey offers you imortality if you can solve a riddle in " + numberOfAttempts);
            Console.ReadKey();

            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.Clear();
                Console.WriteLine("What has to be broken befor you can use it?");
                int attemptsRemaining = numberOfAttempts - i;
                Console.WriteLine("Attempts Remaining: " + attemptsRemaining);
                Console.Write("> ");
                input = Console.ReadLine();

                if (input == "egg")
                {
                    Console.WriteLine("Congrates! You've gained immortality!");
                    break;
                }
                Console.WriteLine("Incorrect! The monkey laughs at you! It hurts...." + "\n you take 5 points of damage.");
                health -= 5;                
            }
            Console.WriteLine($"Your Hp: {health}");

            //First Choice
            validInputReceived = false;
            while (validInputReceived == false)
            {                                   
                Console.WriteLine("You approach a cave. " + "\nDo you go into the cave? " + "\n1.Yes \n2.No");
                input = Console.ReadLine();

                if (input == "1" || input == "Yes")
                {
                    validInputReceived = true;
                    Console.WriteLine("You enter the cave. Wow you are brave.");
                    
                }

                else if (input == "2" || input == "No")
                {
                    validInputReceived = true;
                    Console.WriteLine("You try turning around and going to leave, but you trip and fall in anyway. Nice try.");
                    
                }

                else
                {
                    Console.WriteLine("Invalid Choice");
                }
             }

            //Second Encounter
            {
                Console.WriteLine("Now that you are in the cave you hear the sound of rocks gringing . You look where you just entered from to see the faint light disapear.");
                Console.WriteLine("Your stuck in the cave with only one way to go, so you go deeper into the cave. ");

            }












        }
    }
}
