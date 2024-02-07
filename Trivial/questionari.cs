using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivial
{
    internal class questionari
    {
        string pregunta;
        string r1;
        string r2;
        string r3;
        string r4;
        string correcte;
        public questionari(string pregunta, string r1, string r2, string r3, string r4, string correcte) 
        { 
            this.pregunta = pregunta;
            this.r1 = r1;
            this.r2 = r2;
            this.r3 = r3;
            this.r4 = r4;
            this.correcte = correcte;
        }
    }


}
