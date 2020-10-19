using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace HelloWorld
{
    class Pokemon
    {
        public string _name;
        public int _health;
        public int _damage;
        public Item _potion;
        public Item _superPotion;
        public Item[] inventory;



        //Basic stats for a pokemon
        public Pokemon()
        {
            _health = 70;
            _damage = 15;
            inventory = new Item[2];
            _potion.name = "Potion";
            _potion._healthRestored = 10;
            _superPotion.name = "Super Potion";
            _superPotion._healthRestored = 20;
            inventory[0] = _potion;
            inventory[1] = _superPotion;

        }
        public Pokemon(int healthVal, string nameVal, int damageVal)
        {
            _health = healthVal;
            _name = nameVal;
            _damage = damageVal;
        }

       
        // The save function for the player
        public virtual void Save(StreamWriter writer)
        {
            writer.WriteLine("Pokemon Name: " + _name);
            writer.WriteLine("Pokemon Health: " + _health);
            writer.WriteLine("Current Damage: " + _damage);

        }

        
        //The load function for the player
        public virtual bool Load(StreamReader reader)
        {
            if(File.Exists("SaveData.txt") == false)
            {
                return false;
            }

            string name = reader.ReadLine();
            int damage = 0;
            int health = 0;

            if (int.TryParse(reader.ReadLine(), out health) == false)
            {
                return false;
            }
            if (int.TryParse(reader.ReadLine(), out damage) == false)
            {
                return false;
            }

            _name = name;
            _damage = damage;
            _health = health;
            return true;
        }

        //Prints the pokemon stats
        public virtual void PrintStats()
        {
            Console.WriteLine("Pokemon Name: " + _name);
            Console.WriteLine("Pokemon Health: " + _health);
            Console.WriteLine("Current Damage: " + _damage);
        }


        //Gets the player inventory
        public virtual Item[] GetInventory()
        {
            return inventory;

        }

        
        //The attack function for the player
        public virtual int Scratch(Pokemon pokemon, Pokemon enemy)
        {
            Console.WriteLine( _name + " used SCRATCH!");
            enemy._health -= pokemon._damage;
            return enemy._health;
            
        }

       
        //This is used when the player takes damage
        public int TakeDamage(int damageVal, Pokemon pokemon, Pokemon enemy)
        {

            Console.WriteLine("Wild " + enemy._name + " used BITE!!");
            Console.ReadLine();
            Console.WriteLine(pokemon._name + "  took " + enemy._damage + " damage!");

            _health -= damageVal;
            if (_health < 0)
            {
                _health = 0;
            }
            return damageVal;
        }

        public virtual bool IsAlive()
        {
            return _health > 0;
        }

    }
}
