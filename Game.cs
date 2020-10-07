using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
   
    class Game   
    {
        private bool _gameover = false;
        private Enemy enemy = new Enemy();
        //Run the game
        public void Run()
        {
            Start();

            while (_gameover == false)
            {
                Update();
            }
            End();
        }

       
        //Gets the player to pick their gender and the main pokemon they want to use
        public void Intro()
        {
            Console.WriteLine("Hello there! Welcome to the world of pokemon! I'm Professor Evergreen!" +
                "\n This is the Codenn region, and you will meet plenty of pokemon here!");
            Console.ReadLine();
            Console.WriteLine("Now are you a BOY or a GIRL?");

            char input = Console.ReadKey().KeyChar;
            
           switch (input)
            {
                case '1':
                    {
                        Console.WriteLine("A BOY huh?");
                        Console.ReadLine();
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine("A GIRL huh?");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Are you a BOY or a GIRL?");
                        return;
                    }
            }

            Console.WriteLine("Okay now it's time to choose your starter pokemon. You can only pick one so pick wisely!");
            Console.ReadLine();
            Console.WriteLine("You can pick the grass type Rowlet (1)");
            Console.WriteLine("You can pick the water type Popplio (2)");
            Console.WriteLine("Or you can pick the fire type Litten (3)");
            Console.WriteLine("Pick a number");

            input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    {
                        Console.WriteLine("ROWLET? I'm sure you two will get along nicely! ");
                        
                        
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine("POPPLIO? I'm sure you two will get along nicely!");
                        Pokemon pokemon = new Popplio();
                        break;
                    }
                case '3':
                    {
                        Console.WriteLine("LITTEN? I'm sure you two will get along nicely!");
                        Pokemon pokemon = new Litten();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You didn't pick one of the three starters. I will give you the DEFAULT POKEMON. " +
                            "I'm sure you two will get along nicely!");
                        Pokemon pokemon = new Pokemon();
                        break;
                    }
            }

            Console.WriteLine("Okay now it's time for you to explore Codenn and be the best pokemon trainer out there!");
            
            
        }

        public void Battle(Rowlet rowlet, Enemy enemy)
        {
            while (rowlet._health >= 100 && enemy._health >= 100)
            {
                rowlet.PrintStats();
            }
        }

        //Performed once when the game begins
        public void Start()
        {
            Intro();
            
        }

        //Repeated until the game ends
        public void Update()
        {
            
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
