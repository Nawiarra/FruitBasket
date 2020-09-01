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

                SelectedValue = CurrentValueForSelect;

                NumbersForCheatersOnly.Add(SelectedValue);
            }
        }

        public override string Victory()
        {
            return "Evil laugh x2";
        }
    }
}
