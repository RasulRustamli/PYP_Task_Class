using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Task_Class.Abstract
{
    public abstract class Instrument
    {
        public string Model { get; set; } = null!;
        public double Price { get; set; } 
        public string Brand { get; set; } = null!;
        public abstract string Sound();


    }
}
