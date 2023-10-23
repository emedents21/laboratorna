using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class Vidrizok
    {
        private string name;
        private double start;
        private double konec;

        public Vidrizok(string name, double start, double konec)
        {
            this.name = name;
            this.start = start;
            this.konec = konec;
        }
        
        public string getname()
        {
            return name;
        }

        public void setname(string name)
        {
            this.name = name;
        }

        public double getstart()
        {
            return start;
        }

        public void setstart(double start)
        {
            this.start = start;
        }

        public double getkonec()
        {
            return konec;
        }

        public void setkonec(double konec)
        {
            this.konec = konec;
        }

        public double Lenght()
        {
            return Math.Abs(konec - start);
        }
    }
}
