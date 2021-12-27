using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTextArena
{
    class Gladiator : Entity
    {
        public Gladiator()
        {
            Name = "Gladiator";
            ToHit = 10;
            Damage = 8;
            Hitpoints = 20;
            MaxHitpoints = 20;
            Initiative = 2;
            IntroFlav = "\n\nYou were purchased by a gladiatorial school. You were trained for months. " +
            "You were given soft straw to sleep on and clean linen to wear. You were fed and groomed and " +
            "cured of any injury or ailments. You became an investment. After many more victories, that " +
            "investment has paid for itself ten times over. You have not only become valuable, but you " +
            "have become a value. You are now a standard by which new recruits are measured, and they " +
            "always fall short. \n\nThis dance has become a routine, one in which you relish. Today you " +
            "fight the captain of a rival school—a fighter who is said may soon dethrone the emperor’s own " +
            "champion. You have no doubt in your victory. Pride has replaced fear in your heart. If you would " +
            "fall today, it would be for the glory of the arena and the honor of your school. But you will not " +
            "fall, for you have your sights set on an opponent more worthy than the gladiator across from you " +
            "now. \n\n\nAs you ready yourself, your opponent begins to charge.";
            OutroFlav = "\n\nThe gladiator falls, the thumb follows, and your blade marks another tally on your " +
            "record. When you entered the arena, you were nameless. You were a newborn with no parents to care for " +
            "you. But when you entered your school, they became your father, your brothers, your family. Along with " +
            "this embrace, they gave you a new name. A proper name. A name which the crowd chants with fervor today.";
            WoundedFlav = "\n\nYou have clearly wounded the gladiator, but his training hides it well.";
            WoundedPrint = false;
        }
    }
}
