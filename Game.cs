using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
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

        public void GetInput(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);
            Console.Write("> ");

            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Please pick a gender.");
                }
            }
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

        
        //The get input fucntion for selecting an item in battle
        public virtual void GetInput(out char input, Item Item1, Item Item2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1. " + _potion.name);
            Console.WriteLine("2. " + _superPotion.name);
            Console.WriteLine("> ");

            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Please pick an item.");
                }
            }

        }

        
        //Save function for Rowlet
        public void RowletSave()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            _rowlet.Save(writer);
            writer.Close();
        }

        //Load function for Rowlet
        public void RowletLoad()
        {
            StreamReader reader = new StreamReader("SaveData.txt");
            _rowlet.Load(reader);
            reader.Close();
        }

        
        //Save function for Popplio
        public void PopplioSave()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            _popplio.Save(writer);
            writer.Close();
        }

        //Load function for Popplio
        public void PopplioLoad()
        {
            StreamReader reader = new StreamReader("SaveData.txt");
            _popplio.Load(reader);
            reader.Close();
        }

        
        //Save function for Litten
        public void LittenSave()
        {
            StreamWriter writer = new StreamWriter("SaveData.txt");
            _litten.Save(writer);
            writer.Close();
        }

        //Load function for Litten
        public void LittenLoad()
        {
            StreamReader reader = new StreamReader("SaveData.txt");
            _litten.Load(reader);
            reader.Close();
        }


       
        //Gets the player to pick their gender and the main pokemon they want to use
        public void Intro()
        {
            
            Console.WriteLine("Hello there! Welcome to the world of pokemon! I'm Professor Evergreen!" +
                "\n This is the Codenn region, and you will meet plenty of pokemon here!");
            char input = Console.ReadKey().KeyChar;
            GetInput( out input, "BOY", "GIRL", "Now are you a BOY or a GIRL?");

            
            
           switch (input)
            {
                case '1':
                    {
                        Console.WriteLine(" A BOY huh?");
                        Console.ReadLine();
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine(" A GIRL huh?");
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            Console.WriteLine("Okay now it's time to choose your starter pokemon. You can only pick one so pick wisely!");
            GetInput(out input, "Grass type Rowlet ", "Water type Popplio", "Fire type Litten", "Please select a pokemon");


            //This is where the player picks a pokemon
            switch (input)
            {
                case '1':
                    {
                        Console.WriteLine("ROWLET? I'm sure you two will get along nicely! ");
                        Console.ReadLine();
                        Pokemon pokemon = new Rowlet();
                        RowletSave();
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

        
        
       //This is the battle function for Rowlet
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

                //This is the player options during battle
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
                    _rowlet.GetInventory();
                    GetInput(out input, _potion, _superPotion,  "Pick an item.");
                    

                    if (input =='1')
                    {
                        Console.Clear();
                        Console.WriteLine(" You used a potion! Health restored by " + _potion._healthRestored + "!");
                        _rowlet._health += _potion._healthRestored;
                        _popplio._health += _potion._healthRestored;
                        _litten._health += _potion._healthRestored;
                        Console.ReadLine();
                        _rowlet.TakeDamage(10, _rowlet, _enemy);
                    }
                    if (input =='2')
                    {
                        Console.Clear();
                        Console.WriteLine(" You used a super potion! Health restored by " + _superPotion._healthRestored + "!");
                        _rowlet._health += _superPotion._healthRestored;
                        Console.ReadLine();
                        _rowlet.TakeDamage(10, _rowlet, _enemy);
                    }
               
                    
                }
                if (input =='3')
                {
                    Console.Clear();
                    Console.WriteLine("You couldn't get away!!");
                    Console.ReadLine();
                    _rowlet.TakeDamage(10, _rowlet, _enemy);
                }
  
                
            }
            if (_enemy._health <= 0 && _rowlet._health >= 0)
            {
                Console.WriteLine("Rattata fainted!!! You win!!!");
                _gameover = true;
            }
            else if (_rowlet._health <= 0 && _enemy._health >= 0)
            {
                Console.WriteLine("Rowlet fainted!!!");
                _gameover = true;
            }
        }

        
        //This is the battle function for Popplio
        public void BattlePopplio(Pokemon popplio, Pokemon enemy)
        {
            Console.Clear();
            Console.WriteLine("A wild" + _enemy._name + " has appeared!!");
            Console.WriteLine("Go, " + _popplio._name + "!");
            while (_popplio.IsAlive() && _enemy.IsAlive())
            {
                char input;

                _popplio.PrintStats();
                _enemy.PrintStats();
                Console.ReadLine();

                //This is the player options during battle
                GetInput(out input, "1.Scratch", "Bag", "Run", "What will you do?");
                if (input == '1')
                {
                    _popplio.Scratch(_popplio, _enemy);
                    Console.ReadLine();
                    Console.Clear();
                    _popplio.TakeDamage(10, _popplio, _enemy);
                }
                if (input == '2')
                {
                    _popplio.GetInventory();
                    GetInput(out input, _potion, _superPotion, "Pick an item.");


                    if (input == '1')
                    {
                        Console.Clear();
                        Console.WriteLine(" You used a potion! Health restored by " + _potion._healthRestored + "!");
                        _popplio._health += _potion._healthRestored;
                        Console.ReadLine();
                        _popplio.TakeDamage(10, _popplio, _enemy);
                    }
                    if (input == '2')
                    {
                        Console.Clear();
                        Console.WriteLine(" You used a super potion! Health restored by " + _superPotion._healthRestored + "!");
                        _popplio._health += _superPotion._healthRestored;
                        Console.ReadLine();
                        _popplio.TakeDamage(10, _popplio, _enemy);
                    }


                }
                if (input == '3')
                {
                    Console.Clear();
                    Console.WriteLine("You couldn't get away!!");
                    Console.ReadLine();
                    _popplio.TakeDamage(10, _popplio, _enemy);
                }


            }
            if (_enemy._health <= 0 && _popplio._health >= 0)
            {
                Console.WriteLine("Rattata fainted!!! You win!!!");
                _gameover = true;
            }
            else if (_popplio._health <= 0 && _enemy._health >= 0)
            {
                Console.WriteLine("Popplio fainted!!!");
                _gameover = true;
            }

        }

        
        //The battle function for Litten
        public void BattleLitten(Pokemon litten, Pokemon enemy)
        {
            Console.Clear();
            Console.WriteLine("A wild" + _enemy._name + " has appeared!!");
            Console.WriteLine("Go, " + _litten._name + "!");
            while (_litten.IsAlive() && _enemy.IsAlive())
            {
                char input;

                _litten.PrintStats();
                _enemy.PrintStats();
                Console.ReadLine();

                //This is the player options during battle
                GetInput(out input, "1.Scratch", "Bag", "Run", "What will you do?");
                if (input == '1')
                {
                    _litten.Scratch(_litten, _enemy);
                    Console.ReadLine();
                    Console.Clear();
                    _litten.TakeDamage(10, _litten, _enemy);
                }
                if (input == '2')
                {
                    _litten.GetInventory();
                    GetInput(out input, _potion, _superPotion, "Pick an item.");


                    if (input == '1')
                    {
                        Console.Clear();
                        Console.WriteLine(" You used a potion! Health restored by " + _potion._healthRestored + "!");
                        _litten._health += _potion._healthRestored;
                        Console.ReadLine();
                        _litten.TakeDamage(10, _litten, _enemy);
                    }
                    if (input == '2')
                    {
                        Console.Clear();
                        Console.WriteLine(" You used a super potion! Health restored by " + _superPotion._healthRestored + "!");
                        _litten._health += _superPotion._healthRestored;
                        Console.ReadLine();
                        _litten.TakeDamage(10, _litten, _enemy);
                    }


                }
                if (input == '3')
                {
                    Console.Clear();
                    Console.WriteLine("You couldn't get away!!");
                    Console.ReadLine();
                    _litten.TakeDamage(10, _litten, _enemy);
                }


            }
            if (_enemy._health <= 0 && _litten._health >= 0)
            {
                Console.WriteLine("Rattata fainted!!! You win!!!");
                _gameover = true;
            }
            else if (_litten._health <= 0 && _enemy._health >= 0)
            {
                Console.WriteLine("Litten fainted!!!");
                _gameover = true;
            }
        }

        
       
        
        

        //Performed once when the game begins
        public void Start()
        {
            SetItems();
            RowletLoad();
            PopplioLoad();
            LittenLoad();
            
            
        }

        //Repeated until the game ends
        public void Update()
        {
            Intro();
           

        }

        //Performed once when the game ends
        public void End()
        {
            if (_gameover == true)
            {
                Console.WriteLine("Thanks for playing!!");
            }
        }
    }
}
