using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Litten : Pokemon
    {
        private int _fireDamage;
        

        public Litten() : base()
        {
            _name = "Litten";
            _health = 80;
            _damage = (25 + _fireDamage);
            _fireDamage = 5;
            
            
        }

        //The save function for Litten
        public override void Save(StreamWriter writer)
        {
            base.Save(writer);
        }

        
        //The load function for Litten
        public override bool Load(StreamReader reader)
        {
            return base.Load(reader);
        }


        //Prints the pokemon stats
        public override void PrintStats()
        {
            base.PrintStats();
        }


        //Gets the player inventory
        public override Item[] GetInventory()
        {
            return base.GetInventory();
        }


        //The attack function for the pokemon
        public override int Scratch(Pokemon pokemon, Pokemon enemy)
        {
            return base.Scratch(pokemon, enemy);
        }

        public int TakeDamage(int damageval, Pokemon litten, Pokemon enemy)
        {
            _health -= damageval;
            if (_health < 0)
            {
                _health = 0;
            }
            return damageval;
        }


        //Checks to see if the player is alive
        public override bool IsAlive()
        {
            return base.IsAlive();
        }

    }
}
