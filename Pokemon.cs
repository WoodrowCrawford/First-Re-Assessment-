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
        public Item[] inventory;

        

        public Pokemon()
        {
            _name = "Basic Pokemon";
            _health = 70;
            _damage = 15;

        }
        public Pokemon(float healthVal, string nameVal)

        public virtual void Save(StreamWriter writer)
        {
            writer.WriteLine("Pokemon Name: " + _name);
            writer.WriteLine("Pokemon Health: " + _health);
            writer.WriteLine("Current Damage: " + _damage);
            
        }


        public virtual float Scratch(Enemy enemy)
        {
            Console.WriteLine("BASIC POKEMON used SCRATCH!");
            float damageTaken = enemy.TakeDamage(_damage);
            return damageTaken;
            
        }

        public virtual float TakeDamage(float damageVal)
        {
            _health -= damageVal;
            if (_health < 0)
            {
                _health = 0;
            }
            return damageVal;
        }

    }
}
