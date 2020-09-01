using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    class NotepadPlayer : BasePlayer
    {
        protected static int size = 20;

        private int[] arrayNumbers;
        public int index { get; protected set; }

        NotepadPlayer()
        {
            arrayNumbers = new int[size];
        }

        public override void SelectNextNumber()
        {
            bool isUnique = false;

            Random rnd = new Random();

            if (index < size)
            {
                while (!isUnique)
                {
                    arrayNumbers[index] = rnd.Next(40, 140);

                    for (int i = 0; i < index; i++)
                    {
                        if(arrayNumbers[index] == arrayNumbers[i])
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
            return "Okay, I am writing this in my notepad!";
        }
    }
}
