using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var4
{
    class Cube
    {
        private Point CenterPoint;
        private Point XPoint;
        private Point YPoint;
        private Point ZPoint;
        private Point CenterPoint1;
        private Point XPoint1;
        private Point YPoint1;
        private Point ZPoint1;



        public Cube(Point centerPoint, Point xPoint, Point yPoint, Point zPoint, Point centerPoint1, Point xPoint1, Point yPoint1, Point zPoint1) 
        {
            if (yPoint.Y != centerPoint.Y)
            {
                throw new ArgumentException("Invalid Data!");
            }
            if (xPoint.X != centerPoint.X)
            {
                throw new ArgumentException("Invalid Data!");
            }
            if (zPoint.Z != centerPoint.Z)
            {
                throw new ArgumentException("Invalid Data!");
            }
            if (yPoint1.Z != centerPoint1.Z)
            {
                throw new ArgumentException("Invalid Data!");
            }
            if (xPoint1.X != centerPoint1.X)
            {
                throw new ArgumentException("Invalid Data!");
            }
            if (yPoint1.Y != centerPoint1.Y)
            {
                throw new ArgumentException("Invalid Data!");
            }
            CenterPoint = centerPoint;
            XPoint = xPoint;
            YPoint = yPoint;
            ZPoint = zPoint;

            CenterPoint1 = centerPoint1;
            XPoint1 = xPoint1;
            YPoint1 = yPoint1;
            ZPoint1 = zPoint1;
        }
        public double Square
        {
            get
            {
                return (Math.Pow((Math.Sqrt(Math.Pow(this.P1.X - this.P2.X, 2)
                    + Math.Pow(this.P1.Y - this.P2.Y, 2)
                    + Math.Pow(this.P1.Z - this.P2.Z, 2))), 2));
            }

        }
    }
}
