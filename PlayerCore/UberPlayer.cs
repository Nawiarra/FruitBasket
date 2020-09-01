using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    public class UberPlayer : BasePlayer
    {
        private int currentValueForSelect = 40;

        private int coeff = 0;
        public override void SelectNextNumber()
        {
            selectedValue = currentValueForSelect + coeff;

            numbersForCheatersOnly.Add(selectedValue);

            coeff++;
        }

        public override string Victory()
        {
            return "Well, it was easy!";
        }
    }
}
