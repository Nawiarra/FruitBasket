using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLib
{
    public class Validation
    {
        public static int IntValidation(string line)
        {
            int result;

            if (!int.TryParse(line, out result))
            {
                return int.MinValue;
            }

            return result;
        }
    }
}
