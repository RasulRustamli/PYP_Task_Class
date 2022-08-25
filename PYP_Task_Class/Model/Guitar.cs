using PYP_Task_Class.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Task_Class.Model
{
    public class Guitar : Instrument
    {

        public int HeadStock { get; set; }
        public override string Sound()
        {
            return "9 octave sound";
        }
    }
}
