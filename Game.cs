using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
   
    struct Item
    {
        public string name;
        public int _healthRestored;
    }
    class Game   
    {
        private bool _gameover = false;
        private Pokemon _litten = new Litten();
        private Pokemon _rowlet = new Rowlet();
        private Pokemon _popplio = new Popplio();
        private Enemy _enemy = new Enemy();
        private Item _potion;
        private Item _superPotion;
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

        public void SetItems()
        {
            _potion.name = "Potion";
            _potion._healthRestored = 10;
            _superPotion.name = "Super Potion";
            _superPotion._healthRestored = 20;
        }

        public void GetInput(out char input, string option1, string option2, string option3, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.WriteLine("3." + option3);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("Please pick an option.");
                }
            }
        }

       
      

       
        //Gets the player to pick their gender and the main pokemon they want to use
        public void Intro()
        {
            Console.WriteLine("Hello there! Welcome to the world of pokemon! I'm Professor Evergreen!" +
                "\n This is the Codenn region, and you will meet plenty of pokemon here!");
            Console.ReadLine();
            Console.WriteLine("Now are you a BOY(1) or a GIRL?(2)");

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
                        Console.WriteLine("I guess it does not really matter");
                        break;
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
                        Console.ReadLine();
                        Pokemon pokemon = new Rowlet();
                        BattleRowlet(_rowlet, _enemy);
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine("POPPLIO? I'm sure you two will get along nicely!");
                        Console.ReadLine();
                        Pokemon pokemon = new Popplio();
                        BattlePopplio(_popplio, _enemy);
                        break;
                    }
                case '3':
                    {
                        Console.WriteLine("LITTEN? I'm sure you two will get along nicely!");
                        Console.ReadLine();
                        Pokemon pokemon = new Litten();
                        BattleLitten(_litten, _enemy);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I'll just give you Litten. He's really nice!");
                        Console.ReadLine();
                        Pokemon pokemon = new Litten();
                        BattleLitten(_litten, _enemy);
                        break;
                    }
            }

            Console.WriteLine("Okay now it's time for you to explore Codenn and be the best pokemon trainer out there!");
            Console.ReadLine();
            Console.Clear();
            
            
        }

        
        
        public void BattleRowlet(Pokemon rowlet, Pokemon enemy)
        {
            Console.Clear();
            Console.WriteLine("A wild" + _enemy._name + " has appeared!!");
            Console.WriteLine("Go, " + _rowlet._name + "!");
            while (_rowlet.IsAlive() && _enemy.IsAlive())
            {
                char input;
               
                _rowlet.PrintStats();
                _enemy.PrintStats();
                Console.ReadLine();
                GetInput(out input, "1.Scratch", "Bag", "Run", "What will you do?");
                if (input == '1')
                {
                    _rowlet.Scratch(_rowlet, _enemy);
                    Console.ReadLine();
                    Console.Clear();
                    _rowlet.TakeDamage(10, _rowlet, _enemy);
                }
                if (input == '2')
                {
                    _rowlet.GetInventory(Item [])
                }
  
                
            }
            if (_enemy._health <= 0)
            {
                Console.WriteLine("Rattata fainted!!! You win!!!");
            }
            else if (_rowlet._health <= 0)
            {
                Console.WriteLine("Rowlet fainted!!!");
            }
        }

        public void BattlePopplio(Pokemon popplio, Pokemon enemy)
        {
            Console.Clear();
            Console.WriteLine("A wild" + _enemy._name + " has appeared!!");
            Console.WriteLine("Go, " + _popplio._name + "!");
            while (_popplio.IsAlive() && _enemy.IsAlive())
            {
                _popplio.PrintStats();
                _enemy.PrintStats();
                Console.ReadLine();
                _popplio.TakeDamage(10, _popplio, _enemy);
            }
            if (_popplio._health >= 0)
            {
                Console.WriteLine("Popplio fainted!!!");
            }
        }

        public void BattleLitten(Pokemon litten, Pokemon enemy)
        {
            Console.Clear();
            Console.WriteLine("A wild" + _enemy._name + " has appeared!!");
            Console.WriteLine("Go, " + _litten._name + "!");
            while (_litten.IsAlive() && _enemy.IsAlive())
            {
                
                _litten.PrintStats();
                _enemy.PrintStats();
                Console.ReadLine();
                _litten.TakeDamage(10, _litten, _enemy);
            }
            if (_litten._health >= 0)
            {
                Console.WriteLine("Litten fainted!!!");
            }

        }

        
       
        
        

        //Performed once when the game begins
        public void Start()
        {
            SetItems();
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
