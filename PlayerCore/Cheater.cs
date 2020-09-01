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
                SelectedValue = rnd.Next(40, 140);

                foreach (int number in NumbersForCheatersOnly)
                {
                    if (SelectedValue == number)
                    {
                        break;
                    }
                }

                isUnique = true;

                NumbersForCheatersOnly.Add(SelectedValue);

            }
        }

        public override string Victory()
        {
            return "Evil laugh";
        }
    }
}
