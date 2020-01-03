using System;
using System.Collections.Generic;
using System.Text;

namespace DmgTracker
{
    class Ammunition
    {
        public int PrcShort { get; set; }
        public int PrcMedium { get; set; }
        public int PrcLong { get; set; }
        public int ApShort { get; set; }
        public int ApMedium { get; set; }
        public int ApLong { get; set; }
        public int DmgShort { get; set; }
        public int DmgMedium { get; set; }
        public int DmgLong { get; set; }

        public Ammunition(int prcShort, int prcMedium, int prcLong, 
            int apShort, int apMedium, int apLong, 
            int dmgShort, int dmgMedium, int dmgLong)
        {
            PrcShort = prcShort;
            PrcMedium = prcMedium;
            PrcLong = prcLong;

            ApShort = apShort;
            ApMedium = apMedium;
            ApLong = apLong;

            DmgShort = dmgShort;
            DmgMedium = dmgMedium;
            DmgLong = dmgLong;
        }
    }
}
