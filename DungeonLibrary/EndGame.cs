using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class EndGame
    {
        public static void GameOver()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You live to see another day, but your celebration is for naught; the Red Death claims us all in the end!");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("************GameOver************");
        }
    }
}
