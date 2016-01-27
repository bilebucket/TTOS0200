using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Radio
    {
        private readonly int MIN_VOL = 0, MAX_VOL = 9;
        private readonly double MIN_FREQ = 2000.0, MAX_FREQ = 26000.0;
        private bool power;
        private int volume;
        private double frequency;

        public Radio()
        {

        }

        public bool Power
        {
            get { return power; }
            set {
                power = value;
            }
        }

        public int Volume
        {
            get { return volume; }
            set {
                if (value > MAX_VOL)
                {
                    volume = MAX_VOL;
                } else if (value < MIN_VOL)
                {
                    volume = MIN_VOL;
                } else
                {
                    volume = value;
                }
            }
        }

        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (value > MAX_FREQ)
                {
                    frequency = MAX_FREQ;
                }
                else if (value < MIN_FREQ)
                {
                    frequency = MIN_FREQ;
                }
                else
                {
                    frequency = value;
                }
            }
        }

    }
}
