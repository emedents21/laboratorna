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

        public Line(string name, double start, double konec, string color, double n) : base(name, start, konec)
        {
            this.color = color;
            this.n = n;
        }

        public string getcolor()
        {
            return color;
        }

        public void setcolor(string color)
        {
            this.color = color;
        }
        public double getN()
        {
            return n;
        }

        public void setN(double n)
        {
            this.n = n;
        }

        public double addLenght(double коефіцієнт)
        {
           return n * Lenght();
        }
    }
}
