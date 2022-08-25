using PYP_Task_Class.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Task_Class.Model
{
    public class Piano:Instrument
    {
        public int KeyBoard { get; set; }

        public override string Sound()
        {
            return " 7,5 octave sound";
        }
    }
}
