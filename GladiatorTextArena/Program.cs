using System;
using System.Threading;

namespace GladiatorTextArena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Gladiator Text Arena";
            do
            {
                Console.Clear();
                Console.WriteLine("\n\nPrepare to fight and die for the glory of the arena! " +
                "If you need a list of commands, please type \"help\" on your turn (fullscreen is suggested). Press enter to begin!");
                Console.ReadKey(true);

                Console.WriteLine("\n\nYou had a name, but now your are nameless. You are only a ranking. " +
                "Status and glory are all you can hope to achieve, but those achievements will be forever tied to your new existence. " +
                "You are a gladiator. Your life begins anew, and it will end here--in the arena.");
                Thread.Sleep(3000);
                new Loop().CombatLoop();

                Console.WriteLine("\nPress enter if you wish to play again!");

                Console.ReadKey(true);
            } while (true);
        }
    }
}
