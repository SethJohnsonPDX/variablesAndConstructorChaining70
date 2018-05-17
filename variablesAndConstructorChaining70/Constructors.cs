using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesAndConstructorChaining70
{
    class Constructors
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public int WW { get; set; }
        public Constructors(int wheelWidth) : this("Haro", "BMX", wheelWidth)
        {
        }
        public Constructors(string model, string type, int wheelWidth)
        {
            Model = model;
            Type = type;
            WW = wheelWidth;
        }
    }
}
