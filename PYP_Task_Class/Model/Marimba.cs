using PYP_Task_Class.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Task_Class.Model
{
    public class Marimba : Instrument
    {
        public int TonePlates { get; set; }
        public int Legs { get; set; }

        public override string Sound()
        {
            return "4 1/3 - 5 1/2 octave voices";
        }
    }
}
