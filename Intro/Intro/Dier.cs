using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public class Dier
    {
        public void MaakGeluid()
        {
            Trace.WriteLine("Miauw");
        }
    }

    public class Hond : Dier
    {
        public override void MaakGeluid()
        {
            base.MaakGeluid(); ;
        }
    }
}
