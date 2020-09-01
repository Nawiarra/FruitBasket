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

        public static List<Player> Players = new List<Player>();

        public Game(int selectedSizeOfFruitBasket)
        {
            this.selectedSizeOfFruitBasket = selectedSizeOfFruitBasket;
        }
        public bool StartGame()
        {
            int selectedValue;
            int championNumber;

            while (BasePlayer.numbersForCheatersOnly.Count < 100)
            {
                foreach (Player player in Players)
                {
                    if (BasePlayer.numbersForCheatersOnly.Count == 100)
                    {
                        break;
                    }

                    player.PlayerType.SelectNextNumber();

                    selectedValue = player.PlayerType.ShowPlayerSelectValue();

                    Console.WriteLine($"{player.Name}: I choose {selectedValue}");

                    if (selectedValue == selectedSizeOfFruitBasket)
                    {
                        Victory(player.Name);

                        player.PlayerType.Victory();

                        return true;
                    }
                }
            }

            championNumber = CalculateChampion();

            Victory(Players[championNumber].Name);

            Players[championNumber].PlayerType.Victory();

            return true;
        }

        public void Victory(string playerName)
        {
            Console.WriteLine("Player {0} win!!! Selected value: {1}", playerName, selectedSizeOfFruitBasket);
        }

        public int CalculateChampion()
        {
            int difference = 100;
            int numberChampion = 0;

            for (int i = 0; i < BasePlayer.numbersForCheatersOnly.Count; i++)
            {
                if (difference > Math.Abs(selectedSizeOfFruitBasket - BasePlayer.numbersForCheatersOnly[i]))
                {
                    difference = Math.Abs(selectedSizeOfFruitBasket - BasePlayer.numbersForCheatersOnly[i]);

                    numberChampion = (i + 1) % Game.Players.Count;
                }
            }

            if (numberChampion == 0)
            {
                numberChampion = Game.Players.Count;
            }

            return numberChampion - 1;
        }

    }
}
