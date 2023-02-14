using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Movie
    {
        private string regisseur;
        internal int rating;
        public Movie(int jaar, string titel)
        {
            this.Jaar = jaar;
            this.Titel = titel;
        }
        public int Jaar { get; set; }
        public string Titel { get; set; }

        private int aantalOscars;

        public void showTitle()
        {
            Trace.WriteLine(Titel);
        }

        public  int AantalOscars { 
            get {
                return aantalOscars;
            }
            set
            {
                if (value < 0)
                {
                    aantalOscars = 0;
                }
                else
                {
                    aantalOscars = value;
                }
            }
    }
}