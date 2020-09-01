using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerCore;
using GameCore;
using ValidationLib;
using System.IO;

namespace FruitBasket
{
    class Program
    {
        static int upperBound = 40;
        static int lowerBound = 140;

        static int minPlayersCount = 2;
        static int maxPlayersCount = 8;
        public static int WriteIntValue(string ValueName)
        {
            int WritingValue;

            do
            {
                Console.WriteLine("Give me correct " + ValueName + ": ");

                WritingValue = Validation.IntValidation(Console.ReadLine());
            }
            while (WritingValue == int.MinValue);

            return WritingValue;
        }

        public static string WriteString(string ValueName)
        {
            Console.WriteLine("Give me correct " + ValueName + ": ");

            return Console.ReadLine();
        }

        public static MenuItem WriteMenuItem(string ValueName)
        {
            int WritingValue;

            do
            {
                Console.WriteLine("Give me correct " + ValueName + ": ");

                WritingValue = Validation.IntValidation(Console.ReadLine());
            }
            while (WritingValue == int.MinValue);

            return (MenuItem)WritingValue;
        }

        public static Player AddPalyer(string name, int numberOfPlayersType)
        {
            Player player;

            switch (numberOfPlayersType)
            {
                case 1:
                    {
                        player = new Player(name, new BasePlayer());
                    }
                    break;
                case 2:
                    {
                        player = new Player(name, new NotepadPlayer());
                    }
                    break;
                case 3:
                    {
                        player = new Player(name, new UberPlayer());
                    }
                    break;
                case 4:
                    {
                        player = new Player(name, new Cheater());
                    }
                    break;
                case 5:
                    {
                        player = new Player(name, new UberCheater());
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Error");
                        player = null;
                    }
                    break;

            }
            return player;
        }

        static void Main(string[] args)
        {
            bool isStarting;

            int weight;
            int playersCount;
            int numberOfPlayersType;

            MenuItem userChoice;

            string playerName;

            Player player;

            do
            {
                Console.WriteLine("Press 1 to play game\n2 - for exit ");
                userChoice = WriteMenuItem("menu item");

                Console.Clear();

                switch (userChoice)
                {
                    case MenuItem.Play:
                        {
                            Console.WriteLine("Add fruit backet weight");

                            do
                            {
                                weight = WriteIntValue("weight");
                            }
                            while ((weight < upperBound) || (weight > lowerBound));

                            Game userGame = new Game(weight);

                            Console.WriteLine("Add players count");
                            do
                            {
                                playersCount = WriteIntValue("players count");
                            }
                            while ((playersCount < minPlayersCount) || (playersCount > maxPlayersCount));

                            for (int i = 0; i < playersCount;)
                            {
                                playerName = WriteString("player name");

                                Console.WriteLine("Choose player type:\nBasePlayer - 1;\nNotepadPlayer - 2;\nUberPlayer - 3;\n Cheater - 4;\nUberCheater - 5.\n");
                                numberOfPlayersType = WriteIntValue("player type");

                                player = AddPalyer(playerName, numberOfPlayersType);

                                if (player != null)
                                {
                                    Game.Players.Add(AddPalyer(playerName, numberOfPlayersType));
                                    i++;
                                }

                            }

                            userGame.StartGame();
                        }
                        break;
                    case MenuItem.Exit:
                        {
                            return;
                        }
                    case MenuItem.DoSomethingElse:
                        {
                            Console.WriteLine("I don't understand what do you want to say me.");
                        }
                        break;
                }

            } while (true);
        }
        public enum MenuItem
        {
            DoSomethingElse = 0,
            Play = 1,
            Exit = 2
        }
    }
}
