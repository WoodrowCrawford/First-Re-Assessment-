using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;
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
        

        

        public Pokemon()
        {
            _name = "Basic Pokemon";
            _health = 70;
            _damage = 15;
            Item[] inventory = { _potion, _superPotion };
            

        }
        public Pokemon(int healthVal, string nameVal, int damageVal)
        {
            _health = healthVal;
            _name = nameVal;
            _damage = damageVal;
        }

        public virtual void Save(StreamWriter writer)
        {
            writer.WriteLine("Pokemon Name: " + _name);
            writer.WriteLine("Pokemon Health: " + _health);
            writer.WriteLine("Current Damage: " + _damage);
            
        }

        public virtual void PrintStats()
        {
            Console.WriteLine("Pokemon Name: " + _name);
            Console.WriteLine("Pokemon Health: " + _health);
            Console.WriteLine("Current Damage: " + _damage);
        }

        public virtual void GetInventory(Item[] inventory)
        {
            foreach(Item i in inventory)
            {
                Console.WriteLine(i);
            }

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
