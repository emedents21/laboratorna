using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba2
{
    public class Vorona : bird
    {
        public double L;

        public Vorona(double L)
        { this.L = L; name = "Vorona"; }

        public override double CountEat()
        {
            return L * 0.8;
        }

        public override string Show()
        { 
            return "Птиця - " + name + "  Висота(см) - " + L + "  Кiлькiсть iжi - " + CountEat().ToString();
        }
    }
}
