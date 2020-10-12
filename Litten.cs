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

        public int TakeDamage(int damageval, Pokemon litten, Pokemon enemy)
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
