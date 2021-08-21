using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Youth : Monster
    {
        public Youth()
        {
            MaxLife = 5;
            MaxDamage = 5;
            Name = "Youth";
            HitChance = 20;
            Block = 15;
            MinDamage = 1;
            Life = 6;
            Description = "The unpaved road and the naivety makes Youth a dastardly foe to conquer.";
        }//END YOUTH()
    }
}
