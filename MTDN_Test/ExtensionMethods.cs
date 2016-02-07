using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiTouch
{
    public static class ExtensionMethods
    {
        public static int ToInteger32(this object input)
        {
            int output = 0;

            try
            {
                output = Convert.ToInt32(input);
            }
            catch
            {
            }

            return output;
        }

        public static char ToCharacter(this object input)
        {
            char output = ' ';

            try
            {
                output = Convert.ToChar(input);
            }
            catch
            {
            }

            return output;
        }

        public static bool ToBoolean(this object input)
        {
            bool output = false;

            try
            {
                output = Convert.ToBoolean(input);
            }
            catch
            {
            }

            return output;
        }
    }
}
