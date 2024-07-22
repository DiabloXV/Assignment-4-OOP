using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_OOP.Interface
{
    internal class Warrior : Characterstics, Special_Skills
    {
        public int Health { get; set; }

        public int Level { get; }

        public int BaseDamage { get; }

        public string? Weapon { get; set; }
        public string? Name { get; set; }


        public void Mount()
        {
            Console.WriteLine("Summon Glory Lion mount");
        }

        public void Skill1()
        {
            Console.WriteLine("Keep spinning dealing damage to surround enemies");
        }

        public void Skill2()
        {
            Console.WriteLine("Grant shield to your self for 1s");
        }

        public void Skill3()
        {
            Console.WriteLine("Charge a powerful attack that stund enemies within range");
        }

        void Characterstics.SpecialMove()
        {
            Console.WriteLine("Sleep");
        }

        void Special_Skills.SpecialMove()
        {
            Console.WriteLine("Increase the Attack and defense of allies around you");
        }
    }
}
