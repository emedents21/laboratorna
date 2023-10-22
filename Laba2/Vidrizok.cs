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

        public Vidrizok(string назва, double початкова, double кінцева)
        {
            this.name = назва;
            this.start = початкова;
            this.konec = кінцева;
        }

        public string getname()
        {
            return name;
        }

        public void setname(string назва)
        {
            this.name = назва;
        }

        public double getstart()
        {
            return start;
        }

        public void setstart(double початкова)
        {
            this.start = початкова;
        }

        public double getkonec()
        {
            return konec;
        }

        public void setkonec(double кінцева)
        {
            konec = кінцева;
        }

        public double Довжина()
        {
            return Math.Abs(konec - start);
        }
    }
}
