using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_OOP.Interface
{
    internal interface Characterstics
    {
        public int Health { get; set; }

        public int Level { get; }

        public int BaseDamage { get; }

        public String? Weapon { get; set; }

        public String? Name { get; set; }


        public void Skill1();

        public void skill2();
    }
}
