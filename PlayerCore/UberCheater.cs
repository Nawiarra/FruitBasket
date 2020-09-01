using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    class UberCheater : BasePlayer
    {
        private int CurrentValueForSelect = 40;
        public override void SelectNextNumber()
        {
            bool isUnique = false;

            if (index < size)
            {
                while (!isUnique)
                {
                    foreach (int number in NumbersForCheatersOnly)
                    {
                        if (CurrentValueForSelect == number)
                        {
                            CurrentValueForSelect++;

                            break;
                        }
                    }

                    isUnique = true;

                    arrayNumbers[index] = CurrentValueForSelect;

                    NumbersForCheatersOnly.Add(arrayNumbers[index]);

                    index++;
                }
            }
        }

        public override string Victory()
        {
            return "Evil laugh x2";
        }
    }
}
