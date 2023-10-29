using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Leleka : bird
    {
        public double L;

        public Leleka(double L)
        { this.L = L; name = "Leleka"; }

        public override double CountEat()
        {
            return L * 1 / 2000;
        }

        public override string Show() {
            return "Птиця - " + name + "  Розмах крил(см) - " + L + "  Кiлькiсть iжi - " + CountEat().ToString();
        }
    }
}
