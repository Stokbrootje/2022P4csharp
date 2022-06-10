using System;

namespace oefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RpgCharacter hero = new RpgCharacter(999, 9999, "cloud strife");

            Console.WriteLine(hero.name);
            Console.WriteLine(hero.str);
            Console.WriteLine(hero.hp);
            Console.ReadLine();
        }

    }

    internal class RpgCharacter
    {
        internal int hp;
        internal int str;
        internal readonly string name;
        internal RpgCharacter(int hp, int str, string name)
        {
            this.hp = hp;
            this.str = str;
            this.name = name;
        }
    }
}
