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


        public override void Scratch(ref Enemy _health)
        {
            Console.WriteLine("LITTEN used SCRATCH!");
            
        }

    }
}
