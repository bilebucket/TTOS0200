using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Demo07_Hw03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TVProgram> TVP = new List<TVProgram>();
            TVP.Add(new TVProgram("Heathcliff", "MTV3", "15:00", "15:40", "Story about cats"));
            TVP.Add(new TVProgram("Biker Mice from Mars", "MTV3", "18:00", "18:30", "Hanat auki"));
     
            Stream writeMultipleStream = new FileStream("MyPersons.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeMultipleStream, TVP);
            writeMultipleStream.Close();

            Stream readStream = new FileStream("MyPersons.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            List<TVProgram> readTVP = (List<TVProgram>) formatter.Deserialize(readStream);

            foreach (TVProgram p in readTVP)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
