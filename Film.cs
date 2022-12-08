using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste
{
    public class Film
    {
        // internal - dostepne w ramach paketow

        public string Title { get; set; }

        public int Score { get; set; }

        public string Description { get; set; }

        public string Genre { get; set; }

        public bool Watched { get; set; }

        public Film(string title, int score, string description, string genre)
        {
            Title = title;
            Score = score;
            Description = description;
            Genre = genre;
            Watched = false;
        }
    }
}
