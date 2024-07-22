using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_OOP.Interface
{
    internal class Assassin : Characterstics , Special_Skills
    {
        public int Health { get ; set ; }

        public int Level {  get ;  }

        public int BaseDamage { get ; }

        public string? Weapon { get ; set ; }
        public string? Name { get ; set; }

     

        public void Mount()
        {
            Console.WriteLine("Summon Great Serpent Mount"); 
        }

        public void Skill1()
        {
            Console.WriteLine("Go invisible"); 
        }

        public void Skill2()
        {
            Console.WriteLine("enhance your basic attack");
        }

        public void Skill3()
        {
            Console.WriteLine("Execute low health enimies");
        }

  

        void Characterstics.SpecialMove()
        {
            Console.WriteLine("Dance"); ;
        }

        void Special_Skills.SpecialMove()
        {
            Console.WriteLine("poison enemies");
        }
    }
}
