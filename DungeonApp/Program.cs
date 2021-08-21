using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string characterName;
            int score = 0;
            bool characterMenu = true;
            PlayerCharacter playerCharacter = PlayerCharacter.Prince;

            Console.SetWindowSize(100, 50);

            GameEntry.StartGame();
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(GameBanner.GetGameBanner() + "\n\n");


            //Player's Chosen Name
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter your character's name: ");
            characterName = Console.ReadLine().ToUpper();
            Console.Clear();

            //Select a Character
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                PlayerSelectMenu.PlayerSelect();
                ConsoleKey characterChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (characterChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        playerCharacter = PlayerCharacter.Prince;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        playerCharacter = PlayerCharacter.Buffoon;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        playerCharacter = PlayerCharacter.Improvisatori;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        playerCharacter = PlayerCharacter.BalletDancer;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        playerCharacter = PlayerCharacter.Musician;
                        characterMenu = false;
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        playerCharacter = PlayerCharacter.Beauty;
                        characterMenu = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{characterChoice} was not a valid option. Please, try again.");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                }
            } while (characterMenu);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome, {characterName} the {playerCharacter}!\n\nYour struggle begins anew.");

            Console.Clear();

            //Weapons
            Weapon sword = new Weapon(2, 8, "Sword", 8, true);
            Weapon axe = new Weapon(3, 6, "Axe", 4, true);
            Weapon whip = new Weapon(1, 7, "Whip", 6, false);
            Weapon pistol = new Weapon(1, 3, "Pistol", 3, true);

            //Choosing weapons
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("You've avoided its grasp for this long, but the creeping Red Death waltzes in Prince Prospero's abode, so choose your defensive measures carefully\n");
            System.Threading.Thread.Sleep(4000);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(Book.GetBook() + "\n\n\n");

            bool chosen = false;
            Weapon userWeapon = new Weapon();

            do
            {
                WeaponMenu.Weapons();
                ConsoleKey weaponChoice = Console.ReadKey(true).Key;
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkRed;

                switch (weaponChoice)
                {
                    case ConsoleKey.S:
                        Console.WriteLine("Sharp is the blade, yet it may need more than one hand.\n\n");
                        userWeapon = sword;
                        chosen = true;
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("After lifting the Battle Axe, a surge of courage flows through you as you turn towards the dark lifeless night...\n\n");
                        userWeapon = axe;
                        chosen = true;
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine("A bit lighter, a bit weak, this could be used with one hand.\n\n");
                        userWeapon = whip;
                        chosen = true;
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("Keep the distance between the illness of the wretched Red Death, pull the trigger!\n\n");
                        userWeapon = pistol;
                        chosen = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid choice of weaponry.\n");
                        Console.ResetColor();
                        break;
                }
            } while (!chosen);

            //Player
            Player player = new Player(characterName, 70, 2, 50, 50, playerCharacter, userWeapon);

            System.Threading.Thread.Sleep(8000);
            Console.Clear();

            bool exit = false;
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Battle.GetBattle());
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Press any key to continue.\n");
                Console.ReadKey();
                Console.Clear();

                //Monsters
                Youth youth = new Youth();
                Adulthood adulthood = new Adulthood();
                OldAge oldAge = new OldAge();
                Death death = new Death();

                Monster[] monsters = { youth, adulthood, oldAge, death };

                Random random = new Random();
                int randomMonster = random.Next(monsters.Length);
                Monster monster = monsters[randomMonster];

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Behold! For a foe has appeared! : " + monster.Name + "\n");

                bool reload = false;
                do
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("### Please Choose an Action ###\n\n");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        "[A] Atack\n" +
                        "[R] Run Away\n" +
                        "[P] Player Info\n" +
                        "[M] Monster Info\n" +
                        "[X] Exit \n\n" +
                        "Enemies Defeated: {0}\n\n",
                        score);

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                        case ConsoleKey.Enter:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("=== Attack ===\n");
                            Console.ResetColor();
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("You defeated {0}!!\n\n", monster.Name);
                                Console.ResetColor();

                                reload = true;
                                score++;
                            }
                            break;
                        case ConsoleKey.R:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("=== Run Away ===\n");
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"{monster.Name} attacks you as you run away!\n");
                            System.Threading.Thread.Sleep(500);
                            Combat.DoAttack(monster, player);
                            System.Threading.Thread.Sleep(2500);
                            reload = true;
                            break;
                        case ConsoleKey.P:
                        case ConsoleKey.H:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("=== Player Info ===\n");
                            Console.ResetColor();
                            Console.WriteLine(player);
                            break;
                        case ConsoleKey.M:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("=== Monster Info ===\n");
                            Console.ResetColor();
                            Console.WriteLine(monster);
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.Q:
                        case ConsoleKey.Escape:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Total Enemies Vanquished: {score}\n");
                            EndGame.GameOver();
                            Console.ResetColor();
                            exit = true;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Unrecognized selection.  Please try again.\n");
                            Console.ResetColor();
                            break;
                    }

                    //Player Life
                    if (player.Life <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Now was acknowledged the presence of the Red Death. He had come like a thief in the night. And one by one dropped the revellers in the blood-bedewed halls of their revel, and died each in the despairing posture of his fall. And the life of the ebony clock went out with that of the last of the gay. And the flames of the tripods expired. And Darkness and Decay and the Red Death held illimitable dominion over all.\n");
                        Console.ResetColor();
                        exit = true;
                    }

                } while (!reload && !exit);
            } while (!exit);

        }//END MAIN()

    }//END CLASS

}//END NAMESPACE
