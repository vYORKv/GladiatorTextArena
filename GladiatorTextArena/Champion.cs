using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTextArena
{
    class Champion : Entity
    {
        public Champion()
        {
            Name = "Champion";
            ToHit = 9;
            Damage = 10;
            Hitpoints = 25;
            MaxHitpoints = 25;
            Initiative = 2;
            IntroFlav = "\n\nCountless battles have led to this moment. The Champion stands across from you, glimmering in gilded armor. " +
            "Roses are thrown at his feet, and the crowd showers praise and admiration on their Champion--the emperor's own. " +
            "\n\nHe holds himself with calm and poise. And with good reason--the Champion has won more victories than any gladiator in " +
            "history, and he has never come away with so much as a scratch in all of his fights. They say the blood of the divines run " +
            "through his veins, and therefore it may never be spilled. There is cause to fear him, but you feel no fear. You only feel " +
            "deep respect for a worthy opponent. He is the final challenge you have pursued, and he presents the glory you expect to " +
            "hold. You may respect him, and he may not have been touched by blade before, but today you will make him bleed. " +
            "\n\n\nWith a sure stride, the Champion moves towards you. You ready yourself as he moves to attack.";
            OutroFlav = "\n\nWhat does a man live for? What is his purpose? Most will walk to the grave never knowing the " +
            "answer--never knowing themselves. \n\nYou, however, are not most. You stand above the body of a man many thought " +
            "unbeatable. A man whom many believed was descendant of the gods themselves. Today you have proven this to be false. " +
            "You have taken an immortal and brought him low. And in doing so, you have ascended to take his place. " +
            "You may not be divine, but it is now known the divine are not beyond your reach. Not even the emperor himself " +
            "could withstand your might, for it is his own chosen who lies scarred and exposed before you. " +
            "\n\nPerhaps one day you will fall as this man has, and a new champion will take your place. " +
            "If that happens, so be it. Your legend is not tarnished with the stain of expected immortality. " +
            "Your legend is dethroning those who believe they will hold onto it forever. You are " +
            "kingslayer--godsbane--emperor’s curse. Whatever they may call you a thousand years from " +
            "now matters not, for it will be by name.";
            WoundedFlav = "\n\nYou have landed many blows on the Champion. This alone has shocked and " +
            "livened the crowd. Perhaps you sense fear in his stance? Regardless, he will not go down " +
            "easy, as there is more fight left in him still.";
            WoundedPrint = false;
        }
    }
}
