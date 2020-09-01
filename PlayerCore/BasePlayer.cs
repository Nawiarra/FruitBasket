using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    public class BasePlayer
    {
        protected int SelectedValue;

        protected static List <int> NumbersForCheatersOnly = new List <int> ();

        public int[] ArrayNumbers{get; protected set;}

        public virtual void SelectNextNumber()
        {
            Random rnd = new Random();

            SelectedValue = rnd.Next(40, 140);

            NumbersForCheatersOnly.Add(SelectedValue);
        }

        public virtual string Victory()
        {
            return "Hurray, I am winner!";
        }

        public string ShowPlayerSelectValue()
        {
            return $"I choose {SelectedValue} \n";
        }
    }
}
