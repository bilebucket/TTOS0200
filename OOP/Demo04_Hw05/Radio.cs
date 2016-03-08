using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Hw05
{
    class Radio
    {
        private readonly int MinVol = 0, MaxVol = 9;
        private readonly double MinFreq = 2000.0, MaxFreq = 2600.0;
        private bool power;
        private int volume;
        private double frequency;

        public bool Power
        {
            get { return power; }
            set { power = value; }
        }

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value > MaxVol)
                { volume = MaxVol; }
                else if (value < MinVol)
                { volume = MinVol; }
                else
                { volume = value; }
            }
        }

        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (value > MaxFreq)
                { frequency = MaxFreq; }
                else if (value < MinFreq)
                { frequency = MinFreq; }
                else
                { frequency = value; }
            }
        }
    }
}
