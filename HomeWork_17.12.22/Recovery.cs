using HomeWork_17._12._22;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_17._12._22
{
    internal class Recovery
    {
        public void HealSomebody(Peasant unit)
        {
            if (unit.isDead)
            {
                Console.WriteLine("Пока не могу воскрешать мертвых");
            }
            else
            {
                unit.Health +=  10;
                unit.MyProperty = unit.minMana - 2;
                Console.WriteLine($"Далее {unit.name} восстановил себе здоровье на 10Hp и его здоровье стало: {unit.Health}Hp и при этом {unit.name} потратил на свое восстановление 2 маны и осталось у него {unit.MyProperty}маны");

            }
        }

        public void MaxHealSomebody(Peasant unit)
        {
            int a = 100 - unit.Health;
            int b = a / 5;
            Console.WriteLine($"Далее {unit.name} восстановил себе жизнь на {a}Hp и потратил {b+1} маны");
        }
    }
}





