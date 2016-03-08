using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07_Hw03
{
    [Serializable]
    class TVProgram
    {        
        public string Name { get; set; }
        public string Channel { get; set; }
        public string Startingtime { get; set; }
        public string Endingtime { get; set; }
        public string Info { get; set; }

        public TVProgram(string name, string channel, string st, string et, string info)
        {
            Name = name;
            Channel = channel;
            Startingtime = st;
            Endingtime = et;
            Info = info;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Channel: " + Channel + "\n" + "Starting time: " + Startingtime
                + "\n" + "Ending time: " + Endingtime + "\n" + "Info: " + Info + "\n";
        }
    }
}
