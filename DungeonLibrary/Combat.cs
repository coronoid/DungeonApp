using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 101);

            System.Threading.Thread.Sleep(300);

            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} strikes {1} for {2} damage.\n",
                    attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} missed.\n",
                    attacker.Name);
            }
        }//END DOATTACK

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);

            System.Threading.Thread.Sleep(2000);

            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }//END DOBATTLE()
    }//END CLASS
}//END NAMESPACE
