using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public abstract class bird
    {
        public string name;
        public double L;
        public double Lh;

        public abstract double CountEat();
        public abstract string Show();
    }
}
