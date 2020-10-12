using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Enemy
    {
        private string _name;
        private int _health;
        private int _damage;


        public Enemy()
        {
            _name = "Rattata";
            _health = 60;
            _damage = 10;
        }

        

        public int GetHealth()
        {
            return _health;
        }

        public virtual void Bite(Pokemon pokemon)
        {
            Console.WriteLine("RATTATA used BITE!");
            damageTaken = pokemon.TakeDamage(_damage);
            return damageTaken;
        }
    }
}
