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

            if (index < size)
            {
                while (!isUnique)
                {
                    arrayNumbers[index] = rnd.Next(40, 140);

                    foreach (int number in NumbersForCheatersOnly)
                    {
                        if (arrayNumbers[index] == number)
                        {
                            break;
                        }
                    }

                    isUnique = true;

                    NumbersForCheatersOnly.Add(arrayNumbers[index]);

                    index++;
                }
            }
        }

        public override string Victory()
        {
            return "Evil laugh";
        }
    }
}
