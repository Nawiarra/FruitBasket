using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    public class Cheater : BasePlayer
    {
        public override void SelectNextNumber()
        {
            bool isUnique = false;

            Random rnd = new Random();

            while (!isUnique)
            {
                selectedValue = rnd.Next(40, 140);

                isUnique = true;

                foreach (int number in numbersForCheatersOnly)
                {
                    if (selectedValue == number)
                    {
                        isUnique = false;

                        break;
                    }

                }

            }
            numbersForCheatersOnly.Add(selectedValue);
        }

        public override string Victory()
        {
            return "Evil laugh";
        }
    }
}
