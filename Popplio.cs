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

        public override void Save(StreamWriter writer)
        {
            writer.WriteLine("Pokemon Name: " + _name);
            writer.WriteLine("Pokemon Health: " + _health);
            writer.WriteLine("Current Damage: " + _damage);
        }

        public override void PrintStats()
        {
            base.PrintStats();
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
