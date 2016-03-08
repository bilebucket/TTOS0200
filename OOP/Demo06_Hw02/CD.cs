using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Hw02
{
    class CD
    {
        public string Song { get; set; }
        public string Artist { get; set; }
        public float Length { get; set; }

        public override string ToString()
        {
            return "Song: " + Song + " | Artist: " + Artist + " | Length: " + Length;
        }
    }
}
