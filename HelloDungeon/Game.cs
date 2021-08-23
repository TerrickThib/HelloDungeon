using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {

        //varibles  
        string name = "Empty";
        string characterClass = "";
        int health = 100;
        float power = 0;
        bool gameOver = false;
        int poison = -5;
        string input;
        bool validInputReceived = false;

        //Fuction for Stats To display
        void DisplayStats()
        {
            Console.WriteLine();
            Console.WriteLine(name + " Stats:");
            Console.WriteLine("Class:" + characterClass);
            Console.WriteLine("Health:" + health);
            Console.WriteLine("Power:" + power);
        }

        //Class selection Function
        int GetInput(string description, string option1, string option2)
        {
            string input = "";
            int inputReceived = 0;

            while (inputReceived != 1 && inputReceived != 2)
            {
                //Selection Screen
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.Write("> ");

                //Get input from player
                input = Console.ReadLine();

                //If class pick is knight            
                if (input == "1" || input == option1)
                {
                    //set input recived to the first option
                    inputReceived = 1;
                }

                //If class pick is Wizard
                else if (input == "2" || input == option2)
                {
                    //set input recived to the second option
                    inputReceived = 2;
                }
                //If neither are true
                else
                {
                    //display error
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }

                //so player can read what happened then clear
                Console.ReadKey();
                Console.Clear();
            }
            return inputReceived;
        }

        public void Run()
        {
            //Start Screen
            string start = "Welcome To The Grungen";
            Console.WriteLine(start);

            //Name Exercise

            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.ReadKey();
            Console.Clear();

            //Calling Class Selection
           int Input = GetInput("Select a Class", "Knight", "Wizard");

            //If class pick is knight            
            if (Input == 1)
            {
                characterClass = "Knight";
                health = 100;
                power = 10;
                validInputReceived = true;
            }

            //If class pick is Wizard
            else if (Input == 2)
            {
                characterClass = "Wizard";
                health = 75;
                power = 15;
                validInputReceived = true;
            }
            DisplayStats();

            //Man offers you a potion
            validInputReceived = false;
            while (validInputReceived == false)
            {
                Console.WriteLine("Your aproached by a traveler. " +
                    "\n They offer you a potion. Do you accept?", "\n 1.yes", "\n 2.no");

                input = Console.ReadLine();
                if (input == "1" || input == "yes")
                {
                    Console.WriteLine("It was posion!" + "\n You lose 5 health");
                    Console.WriteLine(health += poison);
                    validInputReceived = true;
                }

                else if (input == "2" || input == "no")
                {
                    Console.WriteLine("You decline his offer and move on.");
                    validInputReceived = true;
                }

                else
                {
                    Console.WriteLine("Invalid Choice");
                    Console.ReadKey();
                }
                Console.ReadKey();
                Console.Clear();
            }



                //Number of attempts a Loop
                int numberOfAttempts = 4;

                Console.WriteLine("A very old man with a monkey on his back approches you." + "\n The monkey offers you imortality if you can solve a riddle in " + numberOfAttempts + "Trys");
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
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.WriteLine($"Your Hp: {health}");

                //First Choice
                validInputReceived = false;
                while (validInputReceived == false)
                {
                    Console.WriteLine("You approach a cave. " + "\nDo you go into the cave? " + "\n1.Yes \n2.No");
                    input = Console.ReadLine();

                    if (input == "1" || input == "yes")
                    {
                        validInputReceived = true;
                        Console.WriteLine("You enter the cave. Wow you are brave.");

                    }

                    else if (input == "2" || input == "no")
                    {
                        validInputReceived = true;
                        Console.WriteLine("You try turning around and going to leave, but you trip and fall in anyway. Nice try Loser.");

                    }

                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

            //Second Encounter
            {
                validInputReceived = false;
                while (validInputReceived == false)
                Console.WriteLine("While in the cave you hear the sound of rocks grinding . You look where you just entered from to see the faint light disapear.");
                Console.WriteLine("Your stuck in the cave with only one way to go, so you go deeper into the cave. ");
                Console.WriteLine("As you go deeper you see a faint light that quickly disapears." + "\n Befor you stands a 12 foot Goblin Daddy ;)");
                Console.ReadKey();
                
                //Choice to attack or talk
                Input = GetInput("What Will you do?", "Try Talking to him", "Attack him");
                if (Input == 1)
                {
                    Console.WriteLine("You Say whats up." + "Amazingly he understands english" + "\n He ask what your doing in his cave.");
                    Console.ReadKey();
                    Console.WriteLine("You say you just wandereed in an would like to leave." + "He understands and moves reveling the exit");
                    Console.ReadKey();
                    Console.WriteLine("You Escaped Congrates" + "Would you like to play Again" + "\n yes" + "\n no");
                    if (input == "yes")
                    {
                        
                    }

                }
                












            }
        }
    }
}

