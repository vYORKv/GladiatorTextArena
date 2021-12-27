using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTextArena
{
    class Barbarian : Entity
    {
        public Barbarian()
        {
            Name = "Barbarian";
            ToHit = 12;
            Damage = 6;
            Hitpoints = 15;
            MaxHitpoints = 15;
            Initiative = 0;
            IntroFlav = "\n\nYou can count the men you have killed on two hands. The past few weeks have been a blur of " +
            "violence--a cacophony of lustful cheering and painful screams. You do not feel you have learned how to fight " +
            "properly, but you take solace in having learned to manage your fear. \n\nThis newfound composure is beginning " +
            "to slip, because today you face a barbarian. A warrior tribesman from the northern horde stands across from you, " +
            "and he is smiling. You have heard tales of the savages’ fearlessness and brutality in battle, but never did you " +
            "expect to witness it first hand. It’s possible that dying to this man would be the most painful death you could " +
            "experience in the arena. It’s also possible that killing him would bring you greater treatment from the slavemaster " +
            "who owns you. With that realization, you set aside your fear and replace it with focus. Today will not be your last.";
            OutroFlav = "\n\nYour opponent laughs as you run him through. He then swings at you with empty fists before you drive" +
            " your weapon deeper into his torso. As his legs began to fail him, you kick his body clear of your blade and send" +
            " him lifeless into the sand. \n\nThe crowd cheers the same cheers, and you sweat the same sweat. But something is" +
            " different this day. You taste something in the air that has alluded you in your life up to this point. What is it?" +
            " You think you know. This is the taste of glory.";
            WoundedFlav = "\n\nYou have bloodied the barbarian to an almost sickening state. A normal man would not be standing. " +
            "However, this man seems to only grow in anger.";
            WoundedPrint = false;
        }
    }
}
