using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Options
    {
        public static void SetMedium()
        {
            Being.ModPlus = MediumMinus;
            Being.ModMinus = MediumPlus;
        }

        private static int MediumPlus(int value)
        {
            return value;
        }

        private static int MediumMinus(int value)
        {
            return value;
        }

        //Analogicznie dla Easy i Hard

    }
}
