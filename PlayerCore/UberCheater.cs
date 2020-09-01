using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    class UberCheater : BasePlayer
    {
        private int currentValueForSelect = 40;
        public override void SelectNextNumber()
        {
            bool isUnique = false;

            while (!isUnique)
            {
                foreach (int number in numbersForCheatersOnly)
                {
                    if (currentValueForSelect == number)
                    {
                        currentValueForSelect++;

                        break;
                    }
                }

                isUnique = true;

                selectedValue = currentValueForSelect;

                numbersForCheatersOnly.Add(selectedValue);
            }
        }

        public override string Victory()
        {
            return "Evil laugh x2";
        }
    }
}
