//make an interaface and implement it 
// implemnt it implecitly and explicitly 
//apply all types of deep copy vs shallow copy



using Assignment_4_OOP.Interface;

namespace Assignment_4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();

            Assassin assassin = new Assassin();

            warrior.Name = "Ahmed";

            warrior.Skill2();

            Special_Skills WarriorSpecialSkill = new Warrior();

            WarriorSpecialSkill.SpecialMove();

            Characterstics Warrior2 = new Warrior();

            Warrior2.SpecialMove();
        }
    }
}
