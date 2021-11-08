using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Circle : Shape
    {
        public Circle(int redCircles, int blueCircles, int yellowCircles)
        {
            Name = "Circle";
            UnitPrice = Constants.CircleUnitPrice;
            NumberOfRedShapes = redCircles;
            NumberOfBlueShapes = blueCircles;
            NumberOfYellowShapes = yellowCircles;
        }

    }
}
