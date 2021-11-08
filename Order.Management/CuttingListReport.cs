using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class CuttingListReport : ReportHelper
    {
        public CuttingListReport(string customerName, string customerAddress, DateTime dueDate, List<Shape> shapes)
        {
            CustomerName = customerName;
            Address = customerAddress;
            DueDate = dueDate;
            OrderedBlocks = shapes;
            tableWidth = Constants.CuttingListReportTableWidth;
        }

        public override void GenerateReport()
        {
            Console.WriteLine($"\nYour cutting list has been generated: \n{OrderDescription()}");
            generateTable();
        }

        void generateTable()
        {
            PrintLine();
            PrintRow("        ", "   Qty   ");
            PrintLine();

            foreach (var shape in OrderedBlocks)
                PrintRow(shape.Name, shape.TotalQuantityOfShape().ToString());

            PrintLine();
        }
    }
}
