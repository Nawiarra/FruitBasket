using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    public class BasePlayer
    {
        protected int selectedValue;

        public static List <int> numbersForCheatersOnly = new List <int> ();

        public virtual void SelectNextNumber()
        {
            Random rnd = new Random();

            selectedValue = rnd.Next(40, 140);

            numbersForCheatersOnly.Add(selectedValue);
        }

        public virtual string Victory()
        {
            return "Hurray, I am winner!";
        }

        public string ShowPlayerSelectValue()
        {
            return $"I choose {selectedValue} \n";
        }
    }
}
