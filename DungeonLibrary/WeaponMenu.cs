using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class WeaponMenu
    {
        public static void Weapons()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("### Select your weapon on this eve ###\n");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "[S] Sword       - Sharp is the blade, yet it may need more than one hand.\n" +
                "[A] Axe         - Powerful, maybe for the Red Death and its minions - two hands are required.\n" +
                "[W] Whip        - A bit lighter, a bit weak, this could be used with one hand.\n" +
                "[P] Pistol      - Keep the distance between the illness of the wretched Red Death, pull the trigger!\n");
        }//END WEAPONS()

    }//END WEAPONMENU
}//END NAMESPACE
