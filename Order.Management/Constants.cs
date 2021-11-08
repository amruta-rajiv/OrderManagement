using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    public class Constants
    {
        public static int SquareUnitPrice = 1;
        public static int TriangleUnitPrice = 2;
        public static int CircleUnitPrice = 3;
        public static List<string> ShapeType = new List<string> { "Squares", "Triangles", "Circles" };
        public static List<string> ShapeColours = new List<string> { "Red", "Blue", "Yellow" };
        public static int InvoiceReportTableWidth = 73;
        public static int CuttingListReportTableWidth = 20;
        public static int PaintingReportTableWidth = 73;
    }
}
