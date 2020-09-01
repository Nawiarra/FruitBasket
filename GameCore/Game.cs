using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerCore;

namespace GameCore
{
    public class Game
    {
        private int selectedSizeOfFruitBasket;

        private static int minPlayersCount = 2;

        private static int maxPlayersCount = 8;

        public static List<Player> Players = new List<Player>();

        public Game(int selectedSizeOfFruitBasket)
        {
            this.selectedSizeOfFruitBasket = selectedSizeOfFruitBasket;
        }
        public bool StartGame()
        {
            if ((Players.Count < minPlayersCount) || (Players.Count > maxPlayersCount))
            {
                return false;
            }

            int selectedValue;

            while (BasePlayer.numbersForCheatersOnly.Count != 100)
            {
                foreach (Player player in Players)
                {
                    player.PlayerType.SelectNextNumber();

                    selectedValue = player.PlayerType.ShowPlayerSelectValue();

                    Console.WriteLine($"{player.Name}: I choose {selectedValue}");

                    if(selectedValue == selectedSizeOfFruitBasket)
                    {
                        Victory(player.Name);

                        player.PlayerType.Victory();
                    }
                }
            }
            return true;
        }

        public void Victory(string playerName)
        {
            Console.WriteLine("Player {0} win!!! Selected value: {1}", playerName, selectedSizeOfFruitBasket);
        }

    }
}
