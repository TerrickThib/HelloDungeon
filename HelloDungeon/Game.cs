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
            
            
            
            
            //Health Exercise

            //Health Default
            int healthRegen = 10;
            int health = 100;
            
            //Name Exercise 
            string name = "Empty";
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            //Displaying Health
            Console.WriteLine($"Your Hp: {health}");

            //Variables  
            int monsterAttack1 = -10;
           

           
            //Second chariter 
            string charater = "Willy" ;
            Console.WriteLine("How did you end up down here " + name);
            charater = Console.ReadLine();
            Console.WriteLine("Well " + name);
            Console.WriteLine("This is the Grungen the place fools come to die. Im Willy the last fool to come here and im apparently not the last");

            
            //Monster Apears 
            Console.WriteLine("A Monster Apears, He attacks and hits you in your chest with his tentical and pushes Willy deeper into the Grungen ");
            Console.WriteLine("You take 10 dammige");
            health += monsterAttack1;
            Console.WriteLine($"Your Hp: {health}");

           //test

            
            
             
            
        }
    }
}
