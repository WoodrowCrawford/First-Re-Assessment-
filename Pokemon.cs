using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Pokemon
    {
        public string _name;
        public int _health;
        public int _damage;

        

        public Pokemon()
        {
            _name = "Basic Pokemon";
            _health = 70;
            _damage = 15;
        }

        public virtual void Save(StreamWriter writer)
        {
            writer.WriteLine("Pokemon Name: " + _name);
            writer.WriteLine("Pokemon Health: " + _health);
            writer.WriteLine("Current Damage: " + _damage);
        }


        public virtual void Scratch(ref Enemy _health)
        {
            Console.WriteLine("BASIC POKEMON used SCRATCH!");
            
        }

    }
}
