using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GladiatorTextArena
{
    class Entity
    {
        Random random = new Random();
        public int Roll(int sides)
        {
            return random.Next(sides) + 1;
        }

        public string Name { get; protected set; }
        public int ToHit { get; protected set; }
        public int Damage { get; protected set; }
        public int Hitpoints { get; set; }
        public int Initiative { get; protected set; }
        public string IntroFlav { get; protected set; }
        public string OutroFlav { get; protected set; }
        public int BlockStat { get; protected set; }
        public int CounterStat { get; protected set; }
        public bool IsDead => Hitpoints <= 0;
        public int Victories { get; protected set; }
        public int MaxHitpoints { get; protected set; }
        public string WoundedFlav { get; protected set; }
        public bool WoundedPrint { get; set; }

        public virtual void Fight(Entity target)
        {
            Attack(target);
        }
        public virtual void Attack(Entity target)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            int roll = Roll(20);
            Console.WriteLine($"\n{Name} rolls a {roll}.");
            if (roll >= ToHit)
            {
                int damageTotal = Roll(Damage);
                target.Hitpoints -= damageTotal;
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} did {damageTotal} damage.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                Console.WriteLine($"\nYou have {target.Hitpoints} hitpoints remaining!");
            }
            else
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{Name} missed!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public virtual void Block(Entity target)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int roll = Roll(20);
            Console.WriteLine($"\nYou roll a {roll} for your block.");
            if (roll >= BlockStat)
            {
                Hitpoints = Math.Min(Hitpoints+2, MaxHitpoints);
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your block was successful! You heal for +2 hitpoints. You now have {Hitpoints} hitpoints.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                Console.WriteLine($"\nYou attack the {target.Name}!");
                Attack(target);
            }
            else
            {
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your block fails!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        
        public virtual void Counter(Entity target)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int roll = Roll(20);
            Console.WriteLine($"\nYou roll a {roll} for your counter attack.");
            if (roll >= CounterStat)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your counter was successful! You slashed out in two furious attacks!");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                Console.WriteLine("\nYour first attack: ");
                Attack(target);
                Thread.Sleep(1000);
                Console.WriteLine("\nYour second attack: ");
                Attack(target);
            }
            else
            {
                Thread.Sleep(1000);
                Hitpoints -= 2;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your counter attack fails! You take -2 hitpoints of damage! You now have {Hitpoints} hitpoints remaining.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


    }
}
