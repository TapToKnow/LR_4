using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LR__1
{
    public class MusicTrack
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        // Добавление переопределения классов
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is MusicTrack))
                return false;

            MusicTrack other = (MusicTrack)obj;
            return this.Artist == other.Artist &&
                   this.Title == other.Title &&
                   this.Genre == other.Genre &&
                   this.Year == other.Year;
        }

        public override int GetHashCode()
        {
            return (Artist?.GetHashCode() ?? 0) ^ (Title?.GetHashCode() ?? 0) ^ (Genre?.GetHashCode() ?? 0) ^ Year.GetHashCode();
        }

        public MusicTrack(string artist, string title, string genre, int year)
        {
            Artist = artist;
            Title = title;
            Genre = genre;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Artist} - {Title} ({Year}) [{Genre}]";
        }
    }
}
