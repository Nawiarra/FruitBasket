using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    class Cheater : BasePlayer
    {
        public override void SelectNextNumber()
        {
            bool isUnique = false;

            Random rnd = new Random();

            while (!isUnique)
            {
                selectedValue = rnd.Next(40, 140);

                foreach (int number in numbersForCheatersOnly)
                {
                    if (selectedValue == number)
                    {
                        break;
                    }
                }

                isUnique = true;

                numbersForCheatersOnly.Add(selectedValue);

            }
        }

        public override string Victory()
        {
            return "Evil laugh";
        }
    }
}
