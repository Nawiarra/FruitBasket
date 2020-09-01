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

        int coeff = 0;
        public override void SelectNextNumber()
        {
            SelectedValue = CurrentValueForSelect + coeff;

            NumbersForCheatersOnly.Add(SelectedValue);

            coeff++;
        }

        public override string Victory()
        {
            return "Well, it was easy!";
        }
    }
}
