using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Popplio : Pokemon
    {
        private int _waterDamage;

        public Popplio() : base()
        {
            _name = "Popplio";
            _health = 90;
            _damage = (16 + _waterDamage);
            _waterDamage = 5;
        }

        
        //The save function for Popplio
        public override void Save(StreamWriter writer)
        {
            base.Save(writer);
        }

        
        //The load function for Popplio
        public override bool Load(StreamReader reader)
        {
            return base.Load(reader);
        }

        public override void PrintStats()
        {
            base.PrintStats();
        }

        public override Item[] GetInventory()
        {
            return base.GetInventory();
        }

        public override int Scratch(Pokemon pokemon, Pokemon enemy)
        {
            return base.Scratch(pokemon, enemy);
        }

        public int TakeDamage(int damageval, Pokemon popplio, Pokemon enemy)
        {
            _health -= damageval;
            if (_health < 0)
            {
                _health = 0;
            }
            return damageval;
        }

        public override bool IsAlive()
        {
            return base.IsAlive();
        }
    }
}
