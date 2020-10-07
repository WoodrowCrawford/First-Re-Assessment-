using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game   
    {
        private bool _gameover = false;
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

       
        //Gets the player to choose the main pokemon they want to use
        public void Intro()
        {
            Console.WriteLine("Why hello there! Welcome to the world of pokemon! I'm Professor Evergreen!");
            Console.ReadLine();
            Console.WriteLine("Now are you a BOY or a GIRL?");
            
            
            
            
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
