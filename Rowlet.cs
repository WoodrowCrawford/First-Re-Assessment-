using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Rowlet : Pokemon
    {
        private int _grassDamage;

        public Rowlet() : base()
        {
            _name = "Rowlet";
            _health = 85;
            _damage = (20 + _grassDamage);
            _grassDamage = 7; 
        }

        public override void Save(StreamWriter writer)
        {
            writer.WriteLine("Pokemon Name: " + _name);
            writer.WriteLine("Pokemon Health: " + _health);
            writer.WriteLine("Current Damage: " + _damage);
        }


        public override void Scratch(ref Enemy _health)
        {
            Console.WriteLine("ROWLET used SCRATCH!");
        }
    }
}
