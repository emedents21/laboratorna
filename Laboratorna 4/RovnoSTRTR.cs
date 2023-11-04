using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna_4
{
    public class EqTriangle : Square
    {
        public EqTriangle(double x, double y, double l1, double angle) : base(x, y, l1, angle)
        {
            this.posX = x;
            this.posY = y;
            this.l1 = l1;
            this.colour = "red";
        }

        public override double Resize(double fact)
        {
            return (l1 * fact);
        }

        public override double Rotate(double angle)
        {
            return angle;
        }

        public override (double, double) Move(double deltaX, double deltaY)
        {
            posX += deltaX;
            posY += deltaY;
            return (posX, posY);
        }

        public override string ChangeColour(string colour)
        {
            return this.colour = colour;
        }

    }
}
