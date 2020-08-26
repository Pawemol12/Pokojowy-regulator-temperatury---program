using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokojowy_regulator_temperatury
{
    static class Constants
    {
        public const int DS1621_MIN_TEMP = -55;
        public const int DS1621_MAX_TEMP = 125;
        public const int HYSTERESIS_MAX_TEMP = 10;
    }
}
