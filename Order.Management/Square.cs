using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Square : Shape
    {
        public Square(int numberOfRedSquares, int numberOfBlueSquares, int numberOfYellowSquares)
        {
            Name = "Square";
            UnitPrice = Constants.SquareUnitPrice;
            NumberOfRedShapes = numberOfRedSquares;
            NumberOfBlueShapes = numberOfBlueSquares;
            NumberOfYellowShapes = numberOfYellowSquares;
        }

    }
}
