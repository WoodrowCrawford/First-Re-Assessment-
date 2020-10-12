using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Enemy : Pokemon
    {
      

        public Enemy() : base()
        {
            _name = "Rattata";
            _health = 60;
            _damage = 10;
        }

        public override void PrintStats()
        {
            base.PrintStats();
        }

        public virtual int Bite(Pokemon pokemon, Pokemon litten, Pokemon popplio, Pokemon rowlet, Pokemon enemy)
        {
            Console.WriteLine("RATTATA used BITE!");
            pokemon._health -= enemy._damage;
            litten._health -= enemy._damage;
            popplio._health -= enemy._damage;
            return pokemon._health;
            

        }

        public  int TakeDamage(int damageVal, Pokemon pokemon, Pokemon enemy)
        {
            return base.TakeDamage(damageVal, pokemon, enemy);
        }

        public override bool IsAlive()
        {
            return base.IsAlive();
        }
    }
}
