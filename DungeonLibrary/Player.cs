using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        public PlayerCharacter PlayerRace { get; set; }
        public Weapon EquipWeapon { get; set; }

        public Player() { }

        public Player(string name, int hitChance, int block, int life, int maxLife, PlayerCharacter playerRace, Weapon equipWeapon)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            PlayerRace = playerRace;
            EquipWeapon = equipWeapon;
        }

        public override string ToString()
        {
            return string.Format("===== {0} =====\n\n" +
                "Life: {1} of {2}\n" +
                "Hit Chance: {3}%\n" +
                "Weapon: {4}\n" +
                "Block: {5}\n" +
                "Race: {6}\n\n",
                Name, Life, MaxLife, CalcHitChance(), EquipWeapon, Block, PlayerRace);
        }//END TOSTRING()

        public override int CalcDamage()
        {
            Random random = new Random();
            int damage = random.Next(EquipWeapon.MinDamage, EquipWeapon.MaxDamage + 1);
            return damage;
        }//END CALCDAMAGE

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquipWeapon.BonusHitChance;
        }//END CALCHITCHANCE
    }//END CLASS
}//END NAMESPACE
