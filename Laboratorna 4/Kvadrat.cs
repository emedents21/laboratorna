using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna_4
{
    public class Square : Point
    {
        protected double l1;
        protected double angle;

        public Square(double l1, double x, double y, double angle) : base(x, y)
        {
            this.l1 = l1;
            this.posX = x;
            this.posY = y;
            this.colour = "blue";
            this.angle = angle;
        }

        public override (double, double) Move(double deltaX, double deltaY)
        {
            posX += deltaX;
            posY += deltaY;
            return (posX, posY);
        }

        public override double Resize(double factor)
        {
            this.l1 = l1 * factor;

            return (l1);
        }

        public override double Rotate(double angle)
        {
            return angle;
        }

        public override string ChangeColour(string colour)
        {
            return this.colour = colour;
        }
    }
}
