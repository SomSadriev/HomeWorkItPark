using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17._12._22
{
    internal class Peasant
    {
        public string name;
        private int _health;
        public int minDamage;
        public int maxDamage;
        private bool _isDead = false;
        public int minMana = 20;
        private int _maxHealth;
        public bool isDead
        {
            get { return _isDead; }
        }

        public Peasant(string name, int _health, int minDamage, int maxDamage)
        {
            this.name = name;
            this._health = _health;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public int MyProperty
        {
            get => minMana;
            
            set 
            {
                minMana = value;
               
            }
        }


        public int Health
        {
            get => _health;

            set
            {
                if (value <= 0)
                {
                    _health = 0;
                    Console.WriteLine($"{name} уничтожен");
                    _isDead = true;
                }
                if (value > 100)
                {
                    _health = 100;
                }
                else
                {
                    _health = value;
                }
                
            }
        }
        public void Onehit(Peasant unit)
        {
            Random random = new Random();
            unit.Health = unit.Health - random.Next(minDamage, maxDamage);
            Console.WriteLine($"{name} нанес удар {unit.name}у и его состояние жизни: {unit.Health}Hp из 100Hp");
        }
    }
}
