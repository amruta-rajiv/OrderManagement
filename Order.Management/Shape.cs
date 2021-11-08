using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Shape
    {
        private static int _additionalCharge = 1;

        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int AdditionalCharge => _additionalCharge;
        public int NumberOfRedShapes { get; set; }
        public int NumberOfBlueShapes { get; set; }
        public int NumberOfYellowShapes { get; set; }

        public int TotalQuantityOfShape()
        {
            return NumberOfRedShapes + NumberOfBlueShapes + NumberOfYellowShapes;
        }

        public double TotalPrice()
        {
            return TotalQuantityOfShape() * UnitPrice;
        }
    }
}
