using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise10_Interfaces
{
    interface IMonster_Undead
    {
        void Undead();
    }
    interface IMonster_Drain_Health
    {
        void Drain_Health();
    }
    interface IMonster_Transform
    {
        void Transform();
    }
    interface IMonster_Fire_Breath
    {
        void Fire_Breath();
    }
    class Zombie : IMonster_Undead
    {
        public void Undead()
        {
            Console.WriteLine("Undead");
        }
    }
    class Vampire : IMonster_Drain_Health, IMonster_Undead
    {
        public void Undead()
        {
            Console.WriteLine("Undead");
        }
        public void Drain_Health()
        {
            Console.WriteLine("Drain Health");
        }
    }
    class Werewolf
    {
        public void Transform()
        {
            Console.WriteLine("Transform");
        }
    }
    class Wyvern
    {
        public void Fire_Breath()
        {
            Console.WriteLine("Fire Breath");
        }
    }
}
