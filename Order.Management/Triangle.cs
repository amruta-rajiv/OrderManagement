using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Triangle : Shape
    {
        public Triangle(int numberOfRedTriangles, int numberOfBlueTriangles, int numberOfYellowTriangles)
        {
            Name = "Triangle";
            UnitPrice = Constants.TriangleUnitPrice;
            NumberOfRedShapes = numberOfRedTriangles;
            NumberOfBlueShapes = numberOfBlueTriangles;
            NumberOfYellowShapes = numberOfYellowTriangles;
        }

    }
}
