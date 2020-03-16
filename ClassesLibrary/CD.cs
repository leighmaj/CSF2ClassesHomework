using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CD
    {
        public Song[] Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public CD(Song[] tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        public CD()
        {

        }

        public override string ToString()
        {
            string trackList = "";

            foreach (Song t in Tracks)
            {
                trackList += t + "\n";
            }

            return string.Format("\n==== CD ====\n\nTitle: {0}\nGenre: {1}\nTracks: {2}\n",
                Title, Genre, trackList);
        }

    }
}
