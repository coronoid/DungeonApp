using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class OldAge : Monster
    {
        public OldAge()
        {
            MaxLife = 10;
            MaxDamage = 9;
            Name = "Old Age";
            HitChance = 20;
            Block = 15;
            MinDamage = 1;
            Life = 10;
            Description = "With experience comes danger, with frailty comes uncertainty. Use this information as you will.";

        }//END OLDAGE()
    }//END CLASS
}//END NAMESPACE
