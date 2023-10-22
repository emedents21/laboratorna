using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class Line : Vidrizok
    {
        private string color;
        private double n;

        public Line(string назва, double початкова, double кінцева, string колір, double n) : base(назва, початкова, кінцева)
        {
            this.color = колір;
            this.n = n;
        }

        public string getcolor()
        {
            return color;
        }

        public void setcolor(string колір)
        {
            this.color = колір;
        }
        public double getN()
        {
            return n;
        }

        public void setN(double n)
        {
            this.n = n;
        }

        public double Збільшення_Довжини(double коефіцієнт)
        {
           return n * Довжина();
        }
    }
}
