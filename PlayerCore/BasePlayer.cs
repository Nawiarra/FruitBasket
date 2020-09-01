using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    public class BasePlayer
    {
        protected static int size = 20;

        protected int[] arrayNumbers;
        public int index { get; protected set; }
        public int[] ArrayNumbers{get; protected set;}

        public BasePlayer()
        {
            arrayNumbers = new int[size];

            index = 0;
        }

        public virtual void SelectNextNumber()
        {
            if (index < size)
            {
                Random rnd = new Random();

                arrayNumbers[index] = rnd.Next(40, 140);
            }

            index++;
        }

        public virtual string Victory()
        {
            return "Hurray, I am winner!";
        }


    }
}
