using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Vorm
    {
        public int Oppervlakte { get; set; }

        public void OutpoutOppervlakte() {
            Trace.WriteLine(Oppervlakte);
        }
    }

    public class Cirkel : Vorm
    {

    }
}
