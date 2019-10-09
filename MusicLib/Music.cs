using System;

namespace MusicLib
{
    public class Music
    {
        public string Titel { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public double Year { get; set; }

        public int Id { get; set; }

        public Music(string titel, string artist, double duration, double year, int id)
        {
            Titel = titel;
            Artist = artist;
            Duration = duration;
            Year = year;
            Id = id;
        }

        public Music()
        {
            
        }
    }
}
