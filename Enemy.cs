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
        }

        public void Bite()
        {
            Console.WriteLine("RATTATA used BITE!");
        }
    }
}
