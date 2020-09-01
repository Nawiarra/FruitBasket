using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCore
{
    public class Player
    {
        public string Name { get; private set; }
        public BasePlayer PlayerType { get; private set; }

        public Player(string name, BasePlayer type)
        {
            Name = name;
            PlayerType = type;
        }

    }
}
