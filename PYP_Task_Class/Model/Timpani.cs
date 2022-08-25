using PYP_Task_Class.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Task_Class.Model
{
    public class Timpani : Instrument
    {
        public int SusPansionRing { get; set; }
        public int Caster { get; set; }

        public override string Sound()
        {
            return " 6/3 --6/3 octave voices";
        }
    }
}
