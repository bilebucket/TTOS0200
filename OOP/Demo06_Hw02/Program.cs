using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Hw02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CD> songs = new List<CD>();

            songs.Add(new CD { Song = "Take Your Time", Artist = "Grafix", Length = 5.51f });
            songs.Add(new CD { Song = "Essence", Artist = "Skrux", Length = 3.38f });
            //Käy läpi ensimmäisen (0)
            Console.WriteLine(songs.ElementAt(0).ToString());

            Console.WriteLine();

            //Käy läpi jokaisen
            foreach (CD song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
