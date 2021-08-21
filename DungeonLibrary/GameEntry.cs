using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class GameEntry
    {
        public static void StartGame()
        {
            Console.Title = "-==== The Masque of the Red Death ====-";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string GameTitle = "****[The Masque of the Red Death]****";
            for (int i = 1; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.Write(GameTitle);
                System.Threading.Thread.Sleep(100);
                GameTitle = " " + GameTitle;
                Console.Clear();
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(GameTitle);
            Console.WriteLine("\n");
            Console.ResetColor();
        }//END STARTGAME()
    }//END CLASS
}//END NAMESPACE
