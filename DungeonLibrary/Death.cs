using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Death : Monster
    {
        public Death()
        {
            MaxLife = 15;
            MaxDamage = 9;
            Name = "Death";
            HitChance = 22;
            Block = 10;
            MinDamage = 1;
            Life = 12;
            Description = "Fight, fight for you life! For it is all you must do to survive Death - if it lets you!";
        }//END DEATH()
    }//END CLASS
}//END NAMESPACE
