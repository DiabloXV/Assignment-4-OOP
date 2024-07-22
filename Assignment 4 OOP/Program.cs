//make an interaface and implement it 
// implemnt it implecitly and explicitly 
//apply all types of deep copy vs shallow copy



using System.Text;
using Assignment_4_OOP.Interface;

namespace Assignment_4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            Warrior warrior = new Warrior();

            Assassin assassin = new Assassin();

            warrior.Name = "Ahmed";

            warrior.Skill2();

            Special_Skills WarriorSpecialSkill = new Warrior();

            WarriorSpecialSkill.SpecialMove();

            Characterstics Warrior2 = new Warrior();

            Warrior2.SpecialMove();
            #endregion

            #region Deep copy vs shallow copy [Value type array]
            int[] originalArray = { 1, 2, 3, 4, 5 };

            int[] shallowCopyArray = originalArray;

            shallowCopyArray[0] = 10;

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("Shallow Copy Array: " + string.Join(", ", shallowCopyArray));




            int[] deepCopyArray = (int[])originalArray.Clone();

            deepCopyArray[0] = 10;

            // Display the original and copied arrays
            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("Deep Copy Array: " + string.Join(", ", deepCopyArray));
            #endregion


            #region string reference type
            string[] originalArray2 = { "one", "two", "three", "four", "five" };

            string[] shallowCopyArray2 = originalArray2;

            shallowCopyArray2[0] = "ten";

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray2));
            Console.WriteLine("Shallow Copy Array: " + string.Join(", ", shallowCopyArray2));






            string[] shallowCopyArray3 = (string[])originalArray.Clone();

            shallowCopyArray3[0] = "ten";

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray2));
            Console.WriteLine("Shallow Copy Array: " + string.Join(", ", shallowCopyArray3));
            #endregion


            #region string builder
            StringBuilder[] originalArray3 = {
            new StringBuilder("one"),
            new StringBuilder("two"),
            new StringBuilder("three"),
            new StringBuilder("four"),
            new StringBuilder("five")
        };

            StringBuilder[] shallowCopyArray4 = originalArray3;


            shallowCopyArray4[0].Append(" modified");


            Console.WriteLine("Original Array:");
            foreach (var sb in originalArray3)
            {
                Console.WriteLine(sb.ToString());
            }

            Console.WriteLine("\nShallow Copy Array:");
            foreach (var sb in shallowCopyArray4)
            {
                Console.WriteLine(sb.ToString());
            }












            StringBuilder[] shallowCopyArray5 = (StringBuilder[])originalArray3.Clone();


            shallowCopyArray5[0].Append(" modified");

 
            Console.WriteLine("Original Array:");
            foreach (var sb in originalArray3)
            {
                Console.WriteLine(sb.ToString());
            }

            Console.WriteLine("\nShallow Copy Array:");
            foreach (var sb in shallowCopyArray5)
            {
                Console.WriteLine(sb.ToString());
            }
            #endregion

        }
    }
}
