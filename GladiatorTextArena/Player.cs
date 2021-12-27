using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTextArena
{
    class Player : Entity
    {
        public int Victories { get; set; }
        public Player()
        {
            Name = "";
            ToHit = 10;
            Damage = 6;
            Hitpoints = 20;
            MaxHitpoints = 20;
            Initiative = 1;
            BlockStat = 12;
            CounterStat = 15;
            Victories = 0;
    }
        public override void Fight(Entity target)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.WriteLine("\nWhat would you like to do?");
            string playerInput = Console.ReadLine().Trim();
            if (playerInput.Equals("attack", StringComparison.OrdinalIgnoreCase))
            {
                Attack(target);
            }
            else if (playerInput.Equals("block", StringComparison.OrdinalIgnoreCase))
            {
                Block(target);
            }
            else if (playerInput.Equals("counter", StringComparison.OrdinalIgnoreCase))
            {
                Counter(target);
            }
            else if (playerInput.Equals("help", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nCommands:\n\"attack\" to attack\n\"block\" to block and heal " +
                "for +2 hitpoints\n\"counter\" to unleash two furious attacks (failed counters will result in -2 damage)");
                Fight(target);
            }      
            else
            {
                Console.WriteLine("\nPlease enter a valid action.");
                Fight(target);
            }
        }

        public override void Attack(Entity target)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int roll = Roll(20);
            Console.WriteLine($"\nYou roll a {roll}.");
            if (roll >= ToHit)
            {
                int damageTotal = Roll(Damage);
                target.Hitpoints -= damageTotal;
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You did {damageTotal} damage.");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"You missed!");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public override void Block(Entity target)
        {
            base.Block(target);
        }

        public override void Counter(Entity target)
        {
            base.Counter(target);
        }

        public void LevelUp()
        {
            Thread.Sleep(2000);
            Console.WriteLine("\n\nYou have leveled up! Pick an attribute to increase:" +
            "\nAccuracy - 1\nBlocking - 2\nCounter Attack - 3\nHitpoints - 4\nStrength - 5");
            var userInput = Console.ReadLine().Trim();
            if (userInput == "1")
            {
                ToHit -= 1;
                Console.WriteLine("\n\nYour accuracy has increased!");
                Thread.Sleep(2000);
            }
            else if (userInput == "2")
            {
                BlockStat -= 1;
                Console.WriteLine("\n\nYour blocking has increased!");
                Thread.Sleep(2000);
            }
            else if (userInput == "3")
            {
                CounterStat -= 1;
                Console.WriteLine("\n\nYour counter attack has increased!");
                Thread.Sleep(2000);
            }
            else if (userInput == "4")
            {
                MaxHitpoints += 5;
                Console.WriteLine("\n\nYour hitpoints have increased by 5!");
                Thread.Sleep(2000);
            }
            else if (userInput == "5")
            {
                Damage += 2;
                Console.WriteLine("\n\nYour strength has increased!");
                Thread.Sleep(2000);
            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine("\n\nInvalid choice! Please choose a stat to increase!");
                Thread.Sleep(1000);
                LevelUp();
            }
        }
    }

}

