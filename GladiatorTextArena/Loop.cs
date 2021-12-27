using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTextArena
{
    class Loop
    {
        //Initiate gameplay loop
        
        Entity[] opponent = { new Slave(), new Barbarian(), new Gladiator(), new Champion() };
        Player player = new Player();
        private void Fight(Entity attacker, Entity defender)
        {
            attacker.Fight(defender);
            defender.Fight(attacker);
        }
       

        public void CombatLoop()
        {
            foreach (Entity opponent in opponent)
            {
                Console.WriteLine(opponent.IntroFlav);
                Thread.Sleep(3000);
                while (true)
                {
                    Entity attacker, defender;
                    if (player.Initiative > opponent.Initiative)
                    {
                        (attacker, defender) = (player, opponent);
                    }
                    else
                    {
                        (attacker, defender) = (opponent, player);
                    }

                    attacker.Fight(defender);

                    if (defender.IsDead || attacker.IsDead)
                    {
                        break;
                    }
                    else if (opponent.Hitpoints <= opponent.MaxHitpoints/2 && !opponent.WoundedPrint)
                    {
                        opponent.WoundedPrint = true;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(1000);
                        Console.WriteLine(opponent.WoundedFlav);
                        Thread.Sleep(2000);
                    }

                    defender.Fight(attacker);

                    if (attacker.IsDead || defender.IsDead)
                    {
                        break;
                    }
                    else if (opponent.Hitpoints <= opponent.MaxHitpoints / 2 && !opponent.WoundedPrint)
                    {
                        opponent.WoundedPrint = true;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Thread.Sleep(1000);
                        Console.WriteLine(opponent.WoundedFlav);
                        Thread.Sleep(2000);
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (player.IsDead)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("\n\nYou fall to the earth and expend your final breath. " +
                    "Your name will not be remembered. If you are remembered, it will not be for " +
                    "any victories to be recounted and retold. Instead, you will be remembered " +
                    "for your final defeat. You will be remembered as a single moment in someone " +
                    "else’s climb to eternal glory.");
                    break;
                }
                else if (opponent is Champion)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(opponent.OutroFlav);
                    Thread.Sleep(3000);
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(opponent.OutroFlav);
                    Thread.Sleep(3000);
                }

                player.LevelUp();

                player.Hitpoints = player.MaxHitpoints;
            }
        }


    }

    
}
