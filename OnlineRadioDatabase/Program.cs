using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 4.Online Radio Database!");

            Console.WriteLine("Please Enter number of songs to add in playlist:");
            int numlist = Int32.Parse(Console.ReadLine());
            //List<Song> playlist = new List<Song>();
            Song[] play = new Song[numlist];
            double playLenght= 0;
            int numSongs = 0;
            for (int i = 0; i < numlist; i++)
            {
                try
                {
                    Console.WriteLine("Please Enter Artist Name: ");
                    string artist = Console.ReadLine();
                    Console.WriteLine("Please Enter Song Name: ");
                    string songName = Console.ReadLine();
                    Console.WriteLine("Please Enter lenght of a song:");
                    double songLenght = double.Parse(Console.ReadLine());
                    Song song = new Song(artist, songName, songLenght);
                    play[i] = song;
                    Console.WriteLine("Song Added");
                    playLenght += play[i].SongLenght;
                    numSongs += 1;
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            TimeSpan interval = TimeSpan.FromMinutes(playLenght);
            Console.WriteLine("Total Song Added :{0}",numSongs);
            Console.WriteLine("Play List Lenght: {0:c}",interval);

            Console.ReadKey();

        }
    }
}
