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
            int health = 100;
            string characterClass;
            int power; 
            //Dammige Attacks

            

            Console.WriteLine("Select a Class");
            Console.WriteLine("1.Knight");
            Console.WriteLine("2.Wizard");

            string input = Console.ReadLine();
            if (input == "1" || input == "Knight")
            {
                characterClass = "Knight";
                health = 100;
                power = 10;
            }
            //Display stats
            Console.WriteLine("Your Characters Stats/n");
            Console.WriteLine("name" + name);
            Console.WriteLine("class" + characterClass);
            Console.WriteLine("health" + health);
            Console.WriteLine("power"
               
            
           
            


           

            
            
             
            
        }
    }
}
