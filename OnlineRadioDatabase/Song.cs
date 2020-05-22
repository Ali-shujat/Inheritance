using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    public class Song
    {
        private string artist;
        private string songName;
        private double songLenght;

        public Song(string artist, string songName, double songLenght)
        {
            this.Artist = artist;
            this.SongName = songName;
            this.SongLenght = songLenght;
        }

        public double SongLenght
        {
            get { return songLenght; }
            set {
                TimeSpan interval = TimeSpan.FromMinutes(value);
                if (value < 0.0 || value > 14.59)
                    throw new ArgumentException("Invalid song length.");
                else if (interval.Minutes < 0 || interval.Minutes > 15)
                    throw new ArgumentException("Song minutes should be between 0 and 14.");
                else if (interval.Seconds < 0 || interval.Seconds > 59)
                    throw new ArgumentException("Song seconds should be between 0 and 59.");
                    songLenght = value; }
        }

        public string SongName
        {
            get { return songName; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.");

                songName = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { if (value.Length < 3 || value.Length > 20)
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                artist = value; }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Type: {this.GetType().Name}")
                            .AppendLine($"Artist Name: {this.Artist}")
                            .AppendLine($"Song Name: {this.SongName}")
                            .AppendLine($"Lenght of Song: {this.SongLenght}");
            return stringBuilder.ToString();
        }
    }
}
