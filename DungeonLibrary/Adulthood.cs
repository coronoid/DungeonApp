using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Adulthood : Monster
    {
        public Adulthood()
        {
            MaxLife = 8;
            MaxLife = 10;
            Name = "Adulthood";
            HitChance = 19;
            Block = 12;
            MinDamage = 1;
            Life = 8;
            Description = "The uncertainty and expectancy of a world not asked for, makes this monster unpredictable.";
        }//END ADULTHOOD()

    }//END CLASS
}//END NAMESPACE
