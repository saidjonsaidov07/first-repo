using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;
        }
        public int RemainingMinutesInOven(int minutes)
        {
            return 40 - minutes;
        }

        public int PreparationTimeInMinutes(int layers)
        {
            return layers*2;
        }

        public int ElapsedTimeInMinutes(int layers, int minutes)
        {
            var layer = layers * 2;
            var left = 40 - minutes;
            var result = left + layer;
            return result;
        }
    }
}
