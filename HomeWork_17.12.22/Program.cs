using HomeWork_17._12._22;
using System;


namespace Start2
{
    class Program
    {
        static void Main()
        {
            Peasant peasant = new Peasant("Aidar", 100, 13, 29);
            Peasant peasant2 = new Peasant("Danil", 100, 41, 79);
            Recovery recover = new Recovery();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Домашнее задание №1");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Событие №{i}");
                peasant.Onehit(peasant2);
                recover.HealSomebody(peasant2);
            }
            Console.WriteLine("-----------------------------------------------------------");


            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Домашнее задание №2");
         
                peasant.Onehit(peasant2);
                recover.MaxHealSomebody(peasant2);

            Console.WriteLine("-----------------------------------------------------------");

        }
    }
}