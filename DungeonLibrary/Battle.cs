using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Battle
    {
        public static string GetBattle()
        {
            //Battle array declaration and initialization
            string[] battle =
            {
                "Decorations, in this chamber, at the eastern extremity was hung, in blue -- and vividly blue were its windows.",
                "This chamber was purple in its ornaments and in its tapestries, and here the panes were bathed in purple.",
                "Inside this chamber room, it was green throughout, and so were the casements.",
                "As the journey grows, you find that this room was furnished and lighted with orange",
                "White within, it is within this chamber you progress further",
                "An oppressive violet overtakes you, yet you steel yourself for what's to come.",
                "Shrouded in black tapestries, it oppresses the room, with windows paned with scarlet hues."
            };

            //Random declaration
            Random random = new Random();
            //Declaration & initialization index from random number up to array length
            int index = random.Next(battle.Length);
            //Declare & Intialize battles getting the battle from the random index
            string battles = "A new encounter approaches you...\n\n" + battle[index] + "\n";
            //Return battles
            return battles;
        }//END GETBATTLE()
    }//END CLASS
}//END NAMESPACE
