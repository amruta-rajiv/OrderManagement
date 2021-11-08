using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class PaintingReport : ReportHelper
    {
        public PaintingReport(string customerName, string customerAddress, DateTime dueDate, List<Shape> shapes)
        {
            CustomerName = customerName;
            Address = customerAddress;
            DueDate = dueDate;
            OrderedBlocks = shapes;
            tableWidth = Constants.PaintingReportTableWidth;
        }

        public override void GenerateReport()
        {
            Console.WriteLine($"\nYour painting report has been generated: \n{OrderDescription()}");
            generateTable();
        }

        void generateTable()
        {
            PrintLine();
            PrintRow("        ", "   Red   ", "  Blue  ", " Yellow ");
            PrintLine();

            foreach (var shape in OrderedBlocks)
                PrintRow(shape.Name, shape.NumberOfRedShapes.ToString(), shape.NumberOfBlueShapes.ToString(), shape.NumberOfYellowShapes.ToString());

            PrintLine();
        }
    }
}
