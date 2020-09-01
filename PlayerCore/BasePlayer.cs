using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    public class BasePlayer
    {
        private static int size = 20;

        private int[] arrayNumbers;
        public int index { get; private set; }
        public int[] ArrayNumbers{get; private set;}

        public BasePlayer()
        {
            arrayNumbers = new int[size];
            index = 0;
        }

        public virtual void SelectNextNumber()
        {
            Random rnd = new Random();
            arrayNumbers[index] = rnd.Next(40, 140);
        }


    }
}
