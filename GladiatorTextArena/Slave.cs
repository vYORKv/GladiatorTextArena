using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTextArena
{
    class Slave : Entity
    {
        public Slave()
        {
            Name = "Slave";
            ToHit = 16;
            Damage = 3;
            Hitpoints = 10;
            MaxHitpoints = 10;
            Initiative = 0;
            IntroFlav = "\n\nToday is the day of your first fight. As the guards come to walk you from your cell, " +
            "you pray that if you should die today, may your death be swift. You are ushered through poorly " +
            "lit tunnels illuminated by torchlight, and you can hear the ruckus of the crowd above. The guards " +
            "stop you at a gate that exits to an arena--one of the nameless amateur fighting pits that litter " +
            "the city. The guards hand you a spear and urge you forward, opening the gate for you as you go. " +
            "\n\nAs you enter the arena, the sound of jeers accompanies blindness from the sudden sunlight and " +
            "overwhelms your senses. As you regain your vision, you see blood staining the sand from the " +
            "countless fights before you; the fights have been brutal. You bring your vision away from a " +
            "nondescript piece of flesh on the ground as the gate across from you opens. \n\nThe man that " +
            "exits looks malnourished and tired. He fidgets uncomfortably with the buckler and shortsword " +
            "in his hands as he shields the sun from his eyes so that he can look at the crowd above. He " +
            "doesn't look like much of a fighter to you. Perhaps he was a farmer indebted to some lord, and " +
            "his time was up. You know that like you, he too has lost his freedom, and now has but one fate " +
            "remaining. He seems scared for a moment, but as his eyes meet your own, his gaze steadies and " +
            "he plants his feet. One thing is certain--if you do not kill him, he will kill you.";
            OutroFlav = "\n\nThe man falls to the ground screaming after suffering a mortal blow. The crowd " +
            "cheers and throws food and empty goblets into the arena. Shouts of \"finish him\" and \"kill him\" " +
            "slur from drunken spectators who came to relish in the violence. You look down at the man who lets " +
            "out a weak \"please\" before coughing blood onto his chin. This final strike will be a mercy. And " +
            "regardless, you are given no choice.";
            WoundedFlav = "\n\nYour attack swings true, and the slave nearly loses his footing. He will not stand for much longer.";
            WoundedPrint = false;
        }
    }
}
