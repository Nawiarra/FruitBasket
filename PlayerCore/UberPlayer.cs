using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    class UberPlayer : BasePlayer
    {
        private int CurrentValueForSelect = 40;
        public override void SelectNextNumber()
        {
            if (index < size)
            {
                arrayNumbers[index] = CurrentValueForSelect + index;

                NumbersForCheatersOnly.Add(arrayNumbers[index]);

                index++;
            }
        }

        public override string Victory()
        {
            return "Well, it was easy!";
        }
    }
}
